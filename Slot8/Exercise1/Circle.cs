// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Slot8
// {
//     public class Circle : GeometricObject
//     {
//         private double radius;

//         public Circle(double x)
//         {
//             this.radius = x;
//         }
//         public Circle(double x, string c, double w) : base(c, w)
//         {
//             this.radius = x;
//         }
//         public override String ToString()
//         {
//             return "Circle has: radius is " + radius + ", color is " + PColor + ", weight is " + PWeight;
//         }
//         public override double findArea() { return Math.PI * radius * radius; }

//         public override double findPerimeter() { return 2 * Math.PI * radius; }

//         static void Main(string[] args)
//         {
//             Circle c1 = new Circle(2.45, "Blue", 23);
//             Console.WriteLine("Circle before change: " + c1.ToString());

//             //using properties
//             c1.PColor = "red";
//             c1.PWeight = 2.56;

//             Console.WriteLine("Circle after change: " + c1.ToString());
//             Console.ReadLine();
//         }

//     }

// }
