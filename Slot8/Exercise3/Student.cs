using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slot8.obj;

namespace Slot8.Exercise3
{
    public class Student : Person
    {
        public string Program { get; set; }
        public Student(string name, decimal phone, string email,  string program) : base(name, phone, email)
        {
            Program = program;
        }
    }
}