using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    class Program
    {
        static void Main()
        {
            string intro = "Hi! My name is ";
            string name = "Shay, ";
            string favColor = "and my favorite color is ";
            string color = "pink!";
            color = color.ToUpper(); // convert this string to uppercase letters
            Console.WriteLine(intro + name + favColor + color); // concatenate these strings accordingly.

            StringBuilder sb = new StringBuilder();




            Console.ReadLine();
        }
    }
}
