using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
                //Skip a line and begin the Daily Report questions.
            Console.WriteLine("\n1. What is your name?"); 
            string name = Console.ReadLine(); //Enter name.
                //After pressing enter for each question, the next question will appear.
            Console.WriteLine("2. What course are you on?"); 
            string course = Console.ReadLine(); //Enter course name.

            Console.WriteLine("3. What page number are you on?");
            string page = Console.ReadLine();
                //Since the page number is an integer, I will cast this string into an int data type.
            int pageNumber = Convert.ToInt32(page); 

            Console.WriteLine("4. Do you need help with anything? Please answer \"true\" or \"false.\" ");
            bool needsHelp = true;
                //Cast this bool into a string data type.
            string helpStatus = Convert.ToString(needsHelp);
            string helpAnswer = Console.ReadLine();

            Console.WriteLine("5. Were there any positive experiences you'd like to share? Please give specifics.");
            string positives = Console.ReadLine();

            Console.WriteLine("6. Is there any other feedback you'd like to provide? Please be specific.");
            Console.ReadLine();

            Console.WriteLine("7. How many hourse did you study?");
            string hoursStudied = Console.ReadLine();

            Console.WriteLine("\nThank you for your answers! An Instructor will respond to this shortly. \nHave  great day!");
            Console.Read();                    
        }
    }
}
