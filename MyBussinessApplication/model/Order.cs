using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBussinessApplication.model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Orderdetail> Orderdetails { get; set; }
       
        public string Status { get; set; }

        public Order()
        {
            Orderdetails = new List<Orderdetail>();
        }
    }
}
