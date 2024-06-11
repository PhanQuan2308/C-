using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBussinessApplication.model;

namespace MyBussinessApplication.service
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        List<Product> GetAllProducts();
    }
}