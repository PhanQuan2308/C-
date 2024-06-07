using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slot8.Exercise3;
using Slot8.obj;

namespace Slot8
{
    public class Faculty : Employee
    {
        public string OfficeHours { get; set; }
        public string Rank { get; set; }

        public Faculty(string name, decimal phone, string email, string department, decimal salary, DateTime dateHired, string officeHours, string rank) : base(name, phone, email, department, salary, dateHired)
        {
            OfficeHours = officeHours;
            Rank = rank;
        }

        public override decimal CalculateBonus()
        {
            return 1000 + 0.5m * Salary;
        }

        public override int CalculateVacation()
        {
            int yearsEmployed = DateTime.Now.Year - DateHired.Year;
            int vacationWeeks = (yearsEmployed >= 3) ? 5 : 4;
            if (yearsEmployed >= 3 && Rank == "Senior Lecturer")
            {
                vacationWeeks++;
            }
            return vacationWeeks;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nOffice Hours: {OfficeHours}\nRank: {Rank}\n";
        }
    }
}