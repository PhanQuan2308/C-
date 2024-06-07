// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Slot3
// {
//     public class Atom
//     {
//         private int atomicNumber;
//         private string symbol;
//         private string fullName;
//         private double atomicWeight;

//         public int AtomicNumber { get; set; }
//         public string? Symbol { get; set; }
//         public string? FullName { get; set; }
//         public double AtomicWeight { get; set; }

//         public bool Accept()
//         {
//             bool validInput = false;

//             while (!validInput)
//             {
//                 Console.Write("Enter atomic number : ");
//                 try
//                 {
//                     atomicNumber = int.Parse(Console.ReadLine());
//                     validInput = true;
//                 }
//                 catch (FormatException)
//                 {
//                     Console.WriteLine("Invalid atomic number. Please enter an integer.");
//                 }
//             }

//             validInput = false;
//             while (!validInput)
//             {
//                 Console.Write("Enter symbol : ");
//                 symbol = Console.ReadLine().Trim();
//                 if (symbol.Length != 1 || !char.IsLetter(symbol[0]))
//                 {
//                     Console.WriteLine("Invalid symbol. Please enter a single letter.");
//                 }
//                 else
//                 {
//                     validInput = true;
//                 }
//             }

//             validInput = false;
//             while (!validInput)
//             {
//                 Console.Write("Enter full name : ");
//                 fullName = Console.ReadLine().Trim();
//                 if (fullName.Length == 0)
//                 {
//                     Console.WriteLine("Invalid full name. Please enter a name.");
//                 }
//                 else
//                 {
//                     validInput = true;
//                 }
//             }

//             validInput = false;
//             while (!validInput)
//             {
//                 Console.Write("Enter atomic weight : ");
//                 try
//                 {
//                     atomicWeight = double.Parse(Console.ReadLine());
//                     validInput = true;
//                 }
//                 catch (FormatException)
//                 {
//                     Console.WriteLine("Invalid atomic weight. Please enter a number.");
//                 }
//             }

//             return true;
//         }

//         public void Display()
//         {
//             Console.WriteLine($"{atomicNumber} {symbol} {fullName} {atomicWeight}");
//         }

//         public static void Main(string[] args)
//         {
//             const int MAX_ATOMS = 10;
//             Atom[] elements = new Atom[MAX_ATOMS];
//             int numElements = 0;

//             Console.WriteLine("Atomic Information");
//             Console.WriteLine("==================");

//             while (numElements < MAX_ATOMS)
//             {
//                 elements[numElements] = new Atom();

//                 if (!elements[numElements].Accept())
//                 {
//                     break; // User entered 0 for atomic number, exit loop
//                 }

//                 numElements++;
//             }

//             if (numElements > 0)
//             {
//                 Console.WriteLine("\nNo\tSym\tName\tWeight");
//                 Console.WriteLine("------------------------------------");
//                 for (int i = 0; i < numElements; i++)
//                 {
//                     elements[i].Display();
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("No elements entered.");
//             }
//         }
//     }

// }