// using System;

// namespace OrderProcessing
// {
//     public class Customer
//     {
//         public string Name { get; set; }

//         public void GreetCustomer()
//         {
//             Console.WriteLine($"Welcome, {Name}!");
//         }
//     }

//     public abstract class Order
//     {
//         public string CustomerName { get; set; }

//         public abstract void ProcessOrder();
//     }

//     public class GroceryOrder : Order
//     {
//         public override void ProcessOrder()
//         {
//             Console.WriteLine($"{CustomerName} has ordered grocery items.");
//         }
//     }

//     public class BakeryOrder : Order
//     {
//         public override void ProcessOrder()
//         {
//             Console.WriteLine($"{CustomerName} has ordered bakery items.");
//         }
//     }

//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             // Accepting customer name
//             Console.WriteLine("Enter your name:");
//             string customerName = Console.ReadLine();

//             Customer customer = new Customer { Name = customerName };

//             // Accepting order choice with validation loop
//             bool validChoice = false;
//             string choice;
//             do
//             {
//                 Console.WriteLine("What would you like to order?");
//                 Console.WriteLine("1 - Grocery Items");
//                 Console.WriteLine("2 - Bakery Products");
//                 choice = Console.ReadLine();

//                 if (choice == "1" || choice == "2")
//                 {
//                     validChoice = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid choice. Please enter 1 or 2.");
//                 }
//             } while (!validChoice);

//             // Creating order object based on user's choice
//             Order order;
//             if (choice == "1")
//             {
//                 order = new GroceryOrder();
//             }
//             else
//             {
//                 order = new BakeryOrder();
//             }

//             order.CustomerName = customerName;
//             customer.GreetCustomer();
//             order.ProcessOrder();
//         }
//     }
// }
