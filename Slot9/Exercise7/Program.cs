using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slot9.obj;

namespace Slot9.Exercise7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create Employee objects with different designations and data
            Employee emp1 = new Employee { Name = "Alice", Designation = "Manager", Salary = 80000, Bonus = 8000 };
            Employee emp2 = new Employee { Name = "Bob", Designation = "Senior Lecturer", Salary = 55000, Bonus = 5000 };
            Employee emp3 = new Employee { Name = "Charlie", Designation = "Developer", Salary = 65000, Bonus = 12000 };

            // Process employees using polymorphism
            List<Employee> employees = new List<Employee>() { emp1, emp2, emp3 };
            foreach (Employee emp in employees)
            {
                try
                {
                    emp.ValidateSalary(); // Call ValidateSalary through polymorphism
                    emp.ValidateBonus();
                    Console.WriteLine($"Employee: {emp.Name}, Designation: {emp.Designation}, Salary: {emp.Salary}, Bonus: {emp.Bonus}");
                }
                catch (AmountException ex)
                {
                    Console.WriteLine($"Error for {ex.PersonName}: {ex.Message}");
                }
            }
        }
    }
}