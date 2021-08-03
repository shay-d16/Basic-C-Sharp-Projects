using System;


namespace BooleanAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CAR INSURANCE APPLICATION");

            //AGE 
            Console.WriteLine("\nWhat is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            // This casts the 'age' variable to an integer that can be read from user input
            bool legalAge = age >= 16;
            // This bool ensures that the user is at least 16 years old.

            //DUIs
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false.\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            // This cast creates an input for the user to put in 'true' or 'false'
            bool noDUIs = dui == false;
            // This bool ensures that no user with a DUI can be qualified for insurance.

            //TICKETS
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool maxTickets = tickets <= 2;
            // This bool ensures the user can only qualify if they have 2 or less speeding tickets.

            //QUALIFICATION
            Console.WriteLine("Qualified?");
            bool qualified = legalAge && noDUIs && maxTickets;
            // Utilizing the AND operator, this boolean logic ensures that the user meets all the
            // requirements for qualification.
            Console.WriteLine(qualified);

            Console.ReadLine();
        }
    }
}
