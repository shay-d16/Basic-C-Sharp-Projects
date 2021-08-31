using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        //Creat a class. In that class, create a method that takes two integers as parameters.Make one of them optional.
        //Have the method do a math operation and return an integer result.
        //In the Main() method of the console app, instantiate the class.
        //Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.
        //Call the method in the class, passing in the one or two numbers entered.
        //Try various combinations of numbers on the code, including having no second number.


        static void Main(string[] args)
        {
            Math math = new Math();//instantiate the object 'math' from the 'Math' class.

            Console.WriteLine("Enter a number: ");
            //Ask the user for input
            int num1 = Convert.ToInt32(Console.ReadLine());//Cast user input from string to integer.
            Console.WriteLine("(Optional) Enter a second number:");
            string optionalString = Console.ReadLine();
            //Rather than creating an integer property, this input will be a string to trigger the if statement.

            if (optionalString == "")//If the user input is equal to "blank":
            {
                Console.WriteLine(math.Multiply(num1));
                //Display the 'Multply()' method from the 'Math' class, which will multply user input 
                //by the default value of 14.
            }
            else //otherwise,
            {
                int num2 = Convert.ToInt32(optionalString);//Cast the user input from string to integer
                Console.WriteLine(math.Multiply(num1, num2));
                //Display the 'Multiply()' method from the 'Math' class taking in both values from user input.
                //Rather than multiplying 'num1' by the default value, it is instead multiplied by the
                //user-specified value.

            }

            Console.ReadLine();
        }
    }
}
