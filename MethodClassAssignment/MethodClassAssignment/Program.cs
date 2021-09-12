using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        //PURPOSE:
        // 1. Create a class. In that class, create a void method that takes two integers as parameters.
        // Have the method do a math operation on the first integer and display the second integer to the screen. 
        // 2. In the Main() method of the console app, instantiate the class .
        // 3. Call the method in the class, passing in two numbers. 
        // 4. Call the method in the class, specifying the parameters by name.
        static void Main(string[] args)
        {
            Math math = new Math();//Here we instantiate the Math class as a 'math' object
            math.Display(numA:2, numB:4);
            //Here, we've named the parameters being passed to the void 'Display' method.
            //The name of the parameter and the value are separated by a colon ":"
            Console.ReadLine();
        }
    }
}
