using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slot8.obj
{
    public class Person
    {
      

        public Person(string name, decimal phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
        public string Name{get;set;}
        public decimal Phone{get;set;}
        public string Email{get;set;}
        
        public override string ToString()
        {
            return $"Name: {Name}, Phone: {Phone}, Email: {Email}";
        }
        
    }
}