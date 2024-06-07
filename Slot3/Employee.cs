using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slot3
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private long sin;
        private double salary;

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "First name: " + firstName + " -last name: " + lastName + " -address: " + address + " -sin: " + sin + " -salary: " + salary;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long SIN { get; set; }
        public double Salary { get; set; }

        public double GetSalary()
        {
            return salary;
        }

        public void Bonus()
        {
            salary += GetSalary() * 0.1;
            Console.WriteLine(salary);
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee("Tien", "Nguyen", "BacNinh", 123, 5000);
            
            Console.WriteLine(emp.ToString());
            Console.WriteLine("Bonus:");
            emp.Bonus();

        }

    }
}