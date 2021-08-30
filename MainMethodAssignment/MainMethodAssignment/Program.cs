using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        //PURPOSE: Create a class. In that class, create a method that will take in an integer, create a math operation
        //for this integer (addition, subtraction, etc.), then return the answer as an integer.
        //In the Main() method of the console app, instantiate the class and call the one method, passing in an integer.
        //Display the result to the screen.
        //Add a second method to the class with the same name that will take in a decimal, create a different math
        //operation for it, then return the answer as an integer.
        //In the Main() method of the console app, instantiate the class and call the second method, passing in a
        //decimal. Display the result to the screen.
        //Add a third method to the class, with the same name, that will take in a string, convert it to an integer if
        //possible, do a different math operation to it, then return the answer as an integer.
        //In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen.
        
        static void Main(string[] args)
        {
            Math math = new Math(); 
            //Here, I instantiated the object 'math' of data type 'Math' to call upon the methods in the 'Math' class

            int answer1 = math.Add(23); 
            //using the 'math' object, I can call upon the Add() method from the 'Math' class, and pass in the parameter
            //'23' into the numA variable in the 'Math' class. 
            Console.WriteLine("23 plus 55 equals " + answer1);

            int answer2 = math.Decimal(3.89m);
            Console.WriteLine("Returned as an integer rather than a decimal, 3.89 minus 2 equals " + answer2);

            int answer3 = math.myString("2");//pass in the string "2" to the 'myString' method in the 'Math' class.
            Console.WriteLine("\"2\" multplied by 23 equals " + answer3);

            Console.ReadLine();
        }
    }
}
