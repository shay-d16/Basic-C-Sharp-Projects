using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Shay";
            //string quote = "The woman said, \"Hello, Shay.\" \nHello, new line. \n \t Hello on a tab.";
            //string fileName = "C:\\Users\\Shay";
            //// \n is an escape character for 'new line.'
            //// \t is an escape character for 'tab.'
            //// \\ is the escape character for the backslash itself.

            //string path = @"C:Users\USER\";
            ////'@' tells the string that everything within the quotation marks is
            //// part of the string, no escape sequences are necessary.


            //bool trueOrFalse = name.Contains("S");
            //trueOrFalse = name.EndsWith("s"); ////Here, we just reassigned the bool variable.
            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(path);
            //Console.WriteLine(trueOrFalse); ////This will print the most recent value of the variable 'trueOrFalse.'

            //int length = name.Length; ////This prints out the number of characters the 'name' value has.
            //Console.WriteLine(length);

            //name = name.ToUpper(); ////Converts everything to uppercase.
            //Console.WriteLine(name);

            //name = name.ToLower(); ////Converts everything to lowercase.
            //Console.WriteLine(name);

            //Console.ReadLine();

            // String are 'immuteable,' meaning once they've been created, it's 
            // allocated to memory. So you can't change the string, you can only make 
            // a new string.

            StringBuilder sb = new StringBuilder();
            // 'StringBuilder' is a class that works a lot like 'string' but it
            // is more 'dynamic' in the sense that it can expand without taking
            // up too much memory.

            sb.Append("My name is Shay.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
