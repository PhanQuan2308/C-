using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slot8.Exercise3;
using Slot8.obj;

namespace Slot8
{
    public class Staff : Employee
    {
        public string Title { get; set; }
        public Staff(string name, decimal phone, string email, string department, decimal salary, DateTime dateHired, string title) : base(name, phone, email, department, salary, dateHired)
        {
            Title = title;
        }

        public override decimal CalculateBonus()
        {
            return 0.06m * Salary;
        }

        public override int CalculateVacation()
        {
             int yearsEmployed = DateTime.Now.Year - DateHired.Year;
        return (yearsEmployed >= 5) ? 4 : 3;
        }
        public override string ToString()
        {
            return base.ToString() + $", Title: {Title}";
        }
    }
}