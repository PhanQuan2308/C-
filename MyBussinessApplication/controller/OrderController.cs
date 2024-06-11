using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBussinessApplication.model;
using MyBussinessApplication.service;

namespace MyBussinessApplication.controller
{
    public class OrderController
    {
        private IOrderRepository orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public void AddOrder(Order order)
        {
            orderRepository.AddOrder(order);
        }
        public List<Order> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }
        public Order GetOrderById(int id)
        {
            return orderRepository.GetOrderById(id);
        }
        public void UpdateOrderById(Order order)
        {
            orderRepository.UpdateOrderById(order);
        }
    }
}