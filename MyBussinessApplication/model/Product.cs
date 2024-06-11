using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBussinessApplication.model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product( string name, decimal price, string description){
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
        public Product(){
            
        }
    }
}