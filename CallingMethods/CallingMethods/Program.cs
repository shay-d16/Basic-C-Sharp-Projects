using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); 
            //Here, I instantiated the object 'math' of data type 'Math' to call upon the methods in the 'Math' class.

            Console.WriteLine("Pick a number to use in different math operations for these numbers:");

            int userNumber = Convert.ToInt32(Console.ReadLine());

            int productOne = math.Divide(userNumber); //pass in the user input to this method 
            Console.WriteLine("\n" + productOne);

            int productTwo = math.Multiply(userNumber);
            Console.WriteLine(productTwo);

            int productThree = math.Subtract(userNumber);
            Console.WriteLine(productThree);

            Console.ReadLine();


        }

    }
}
