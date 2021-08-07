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

            sb.Append("As a kid, I really loved the color pink, ");
            sb.Append("but once I hit my teenage years, ");
            sb.Append("I started to think the color itself signified ");
            sb.Append("childlike innocence. So I stopped liking it so much. ");
            sb.Append("Now as an adult in my mid-twenties, ");
            sb.Append("I have fully embraced my love for pink! ");
            sb.Append("It doesn't really matter what anyone thinks of it ");
            sb.Append("as long as it makes me happy!");

            Console.WriteLine(sb);




            Console.ReadLine();
        }
    }
}
