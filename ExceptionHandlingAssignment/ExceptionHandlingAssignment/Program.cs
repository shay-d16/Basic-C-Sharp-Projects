using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment: Create a list of integers. Ask the user for a number to divide each number 
            //the list by. Write a loop that takes each integer in the list, divides it by the number
            //The user entered, and displays the result to the screen. Put the loop in a try/catch block.
            //Below and outside of the try/catch block, make the program print a message to the display
            //to let you know the program has emerged from the try/catch block and continued on with program
            //execution. In the catch block, display the error message to the screen. Then try various 
            //combinations of user input: valid numbers, zero and a string. Ensure the proper error messages
            //display on the screen, and that the code after the try/catch block gets executed.

            Console.WriteLine("Here is a list of integers: ");
            List<int> numbers = new List<int> { 10, 35, 48, 16, 200, 80 };//Create my list of integers
            
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Type in a number to divide each integer on this list by:");

            try
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                //Note: Put this object inside the try block, otherwise it can't catch the error.
                //I entered a string and program stopped executing until I put the variable
                //into this block.
                foreach (int n in numbers)
                {
                    Console.WriteLine(n / userNumber);
                }
            }
            catch (FormatException ex)
            //This exception is thrown when the format of an argument is invalid
            //(i.e. entering a string instead of integer).
            {
                Console.WriteLine(ex.Message);  
            }
            catch(DivideByZeroException)
            //This exception is thrown when there is an attempt to divide an integral or decimal value by 0.                                      
            {
                Console.WriteLine("Please don't type in zero.");    
            }
            catch(Exception ex)//This is for general exceptions, which is basically any other exception that can be caught
            {
                Console.WriteLine(ex.Message);
            }
            finally
            //'finally' ensures that the program will continue to execute whether an exception is thrown or not.
            {
                Console.WriteLine("\nThis program has been successfully executed.");
                Console.ReadLine();
            }
        }
    }
}
