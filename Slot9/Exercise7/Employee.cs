using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slot9.obj;

namespace Slot9.Exercise7
{
    public class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }

        public virtual void ValidateSalary()
        {
            if (Designation == "Senior Lecturer" && Salary < 60000)
            {
                throw new AmountException("Salary is less than minimum for Senior Lecturer", Name);
            }
        }

        public virtual void ValidateBonus()
        {
            if (Bonus > 10000)
            {
                throw new AmountException("Bonus amount exceeds maximum limit", Name);
            }
        }
    }
}