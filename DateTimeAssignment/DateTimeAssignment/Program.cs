using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        //---------------------------------- DATETIME ASSIGNMENT REQUIREMENTS: ----------------------------------------
        //Perform these actions and create a console app that includes the following:
        //1. Prints the current date and time to the console.
        //2. Asks the user for a number.
        //3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
        //-------------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now; //store the current date and time in the 'curentTime' variable
            
            Console.WriteLine("The current date and time is {0}", currentTime); //print to console
            Console.WriteLine("Please enter a number: "); //ask user to input a number
            int hours = Convert.ToInt32(Console.ReadLine()); //convert user input from string to integer

            DateTime newHours = currentTime.AddHours(hours);
            //use the 'AddHours' method to add the user input to the current time in hours and print the time to
            //the console.
            Console.WriteLine("In exactly {0} hours, the time will be {1}.", hours, newHours);

            Console.ReadLine();

        }
       
    }
}
