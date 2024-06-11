using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBussinessApplication.model;
using MyBussinessApplication.service;

namespace MyBussinessApplication.controller
{
    public class ProductController
    {
        private IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            productRepository.CreateProduct(product);
        }
        public List<Product> GetProducts(){
           return productRepository.GetAllProducts();
        }
    }
}