using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slot8.Exercise3
{
    public class Application
    {
         static void Main(string[] args)
        {
            // Tạo đối tượng Student và hiển thị thông tin
            Student student = new Student("A", 123456, "A@example.com", "Computer Science");
            Console.WriteLine(student);

            // Tạo đối tượng Faculty và hiển thị thông tin
            Faculty faculty = new Faculty("B", 21312312, "B@example.com", "Computer Science", 60000, new DateTime(2018, 1, 1), "9am - 5pm", "Associate Professor");
            Console.WriteLine(faculty);

            // Tạo đối tượng Staff và hiển thị thông tin
            Staff staff = new Staff("C", 1321231, "C@example.com", "Administration", 50000, new DateTime(2015, 1, 1), "Office Manager");
            Console.WriteLine(staff);
        }
    }
}