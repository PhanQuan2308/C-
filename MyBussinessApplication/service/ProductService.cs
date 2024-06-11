using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBussinessApplication.model;
using MySql.Data.MySqlClient;

namespace MyBussinessApplication.service
{
    public class ProductService : IProductRepository
    {
        public static string SQL_CREATE_PRODUCT = "INSERT INTO products(name, price, description) VALUES (@name, @price, @description)";
        public static string SQL_GET_ALL = "SELECT * FROM products";

        private MySqlConnection conn;

        

        public ProductService(string connString)
        {
          
            conn = new MySqlConnection(connString);
        }
       

        public void CreateProduct(Product product)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(SQL_CREATE_PRODUCT, conn);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@description", product.Description);
            cmd.ExecuteNonQuery();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(SQL_GET_ALL, conn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                Product product = new Product();
                product.Id = read.GetInt32("id");
                product.Name = read.GetString("name");
                product.Price = read.GetInt32("price");
                product.Description = read.GetString("description");
                products.Add(product);
            }
            return products;
        }
    }
}