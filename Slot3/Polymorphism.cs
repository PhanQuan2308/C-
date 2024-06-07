// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Slot3.obj;

// namespace Slot3
// {
//     public class Polymorphism
//     {
//         static void Main(string[] args){
//             Window win = new Window(1,2);
//             ListBox lb = new ListBox(3,4,"Stand alone list box");
//             Button b = new Button(5,6);
//             win.DrawWindow();
//             lb.DrawWindow();
//             b.DrawWindow();
//             Window[] winArray = new Window[3];
//             winArray[0] = new Window(1,2);
//             winArray[1] = new ListBox(3,4,"Stand alone list box");
//             winArray[2] = new Button(5,6);
//             for(int i = 0; i < 3 ;  i++){
//                 winArray[i].DrawWindow();
//             }
//             Console.ReadLine();
//         }
//     }
// }