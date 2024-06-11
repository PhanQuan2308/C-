using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MyBussinessApplication.model;

namespace MyBussinessApplication.service
{
    public class OrderService : IOrderRepository
    {
        private readonly string connString;

        public OrderService(string connString)
        {
            this.connString = connString;
        }

        public void AddOrder(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.Transaction = transaction;
                    cmd.CommandText = "INSERT INTO orders(customer_id, order_date,status) VALUES (@CustomerId, @OrderDate,@Status)";
                    cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                    cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    cmd.Parameters.AddWithValue("@Status", order.Status);
                    cmd.ExecuteNonQuery();

                    int orderId = (int)cmd.LastInsertedId;

                    foreach (var detail in order.Orderdetails)
                    {
                        MySqlCommand detailCmd = conn.CreateCommand();
                        detailCmd.Transaction = transaction;
                        detailCmd.CommandText = "INSERT INTO order_details (order_id, product_id, quantity) VALUES (@OrderId, @ProductId, @Quantity)";
                        detailCmd.Parameters.AddWithValue("@OrderId", orderId);
                        detailCmd.Parameters.AddWithValue("@ProductId", detail.ProductId);
                        detailCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                        detailCmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }


        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM orders";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Order order = new Order();
                        order.Id = reader.GetInt32("id");
                        order.CustomerId = reader.GetInt32("customer_id");
                        order.OrderDate = reader.GetDateTime("order_date");
                        order.Status = reader.GetString("status");
                        order.Orderdetails = new List<Orderdetail>();
                        orders.Add(order);
                    }
                }
            }

            foreach (var order in orders)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlCommand detailCmd = conn.CreateCommand();
                    detailCmd.CommandText = "SELECT * FROM order_details WHERE order_id = @OrderId";
                    detailCmd.Parameters.AddWithValue("@OrderId", order.Id);
                    using (MySqlDataReader reader = detailCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Orderdetail orderdetail = new Orderdetail();
                            orderdetail.ProductId = reader.GetInt32("product_id");
                            orderdetail.Quantity = reader.GetInt32("quantity");
                            order.Orderdetails.Add(orderdetail);
                        }
                    }
                }
            }
            return orders;
        }

        public Order GetOrderById(int id)
        {
            Order order = null;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM orders WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        order = new Order
                        {
                            Id = reader.GetInt32("id"),
                            CustomerId = reader.GetInt32("customer_id"),
                            OrderDate = reader.GetDateTime("order_date"),
                            Status = reader.GetString("status"),
                            Orderdetails = new List<Orderdetail>()
                        };

                    }


                }
                if (order != null)
                {
                    MySqlCommand detailCmd = conn.CreateCommand();
                    detailCmd.CommandText = "SELECT * FROM order_details WHERE order_id = @order_id";
                    detailCmd.Parameters.AddWithValue("@order_id", order.Id);
                    using (MySqlDataReader detailReader = detailCmd.ExecuteReader())
                    {
                        while (detailReader.Read())
                        {
                            Orderdetail orderdetail = new Orderdetail
                            {
                                ProductId = detailReader.GetInt32("product_id"),
                                Quantity = detailReader.GetInt32("quantity"),
                            };
                            order.Orderdetails.Add(orderdetail);
                        }
                    }

                }

            }
            return order;
        }

        public void UpdateOrderById(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.Transaction = transaction;
                    cmd.CommandText = "UPDATE orders SET status = @status WHERE id = @id";
                    cmd.Parameters.AddWithValue("@Status", order.Status);
                    cmd.Parameters.AddWithValue("@id", order.Id);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();

                }
            }
        }
    }
}
