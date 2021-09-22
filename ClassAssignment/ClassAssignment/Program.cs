using System;

namespace ClassAssignment
{
    static class Program
    {
        static void Main(string[] args)
        {
            //PURPOSE:
            //1. Create a class. In that class, create a void method that outputs an integer.
            //   Have the method divide the data passed to it by 2.
            //2. In the Main() method, instantiate that class.
            //3. Have the user enter a number. Call the method on that number. Display the output
            //   to the screen. It should be the entered number, divided by two.
            //4. Create a method with output parameters.
            //5. Overload a method.
            //6. Declare a class to be static.

            Math math = new Math(); //instantiate the Math class as a "math" object. 

            Console.WriteLine("Enter an integer: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine()); //Convert user input from string to integer.
            math.mathMethod(userInput1); //Call the method and pass in the user input as it's parameter

            Console.WriteLine("Enter another integer: ");
            string userInput2 = Console.ReadLine();
            math.mathMethod(userInput2);

            Console.ReadLine();
        }
    }
}
