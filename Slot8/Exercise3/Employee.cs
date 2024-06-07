using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slot8.obj;

namespace Slot8.Exercise3
{
    public abstract class Employee : Person
    {
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateHired { get; set; }
        public Employee(string name, decimal phone, string email, string department, decimal salary, DateTime dateHired) : base(name, phone, email)
        {
            Department = department;
            Salary = salary;
            DateHired = dateHired;

        }
        public abstract decimal CalculateBonus();
        public abstract int CalculateVacation();

        public override string ToString()
        {
            return base.ToString() + $", Department: {Department}, Salary: {Salary}, DateHired: {DateHired}";
        }
    }

}