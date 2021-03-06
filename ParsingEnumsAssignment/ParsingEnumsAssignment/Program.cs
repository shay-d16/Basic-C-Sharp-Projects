using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        // REQUIREMENTS:
        // 1. Create an enum for the days of the week.
        // 2. Prompt the user to enter the current day of the week.
        // 3. Assign the value to a variable of that enum data type you just created.
        // 4. Wrap the above statement in a try/catch block and have it print
        // "Please enter an actual day of the week.” to the console if an error occurs.
        static void Main(string[] args)
        {
            DaysOfTheWeek day;
            Console.WriteLine("What is the current day of the week?");
                                   

            try
            {
                string v = Console.ReadLine();
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), v);
                Console.WriteLine(day);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
