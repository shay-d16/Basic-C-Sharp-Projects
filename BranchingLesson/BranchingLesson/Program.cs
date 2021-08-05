using System;


namespace BranchingLesson
{
    class Program
    {
        static void Main()
        {


            //CONDITIONAL STATEMENT 1
            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}
            // This is a lot of code than can be condensed using 'ternary operators.'

            //TERNARY OPERATORS 1
            //string comparisonResults = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResults);

            //CONDITIONAL STATEMENT 2
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhh.... something went wrong.");
            //}

            //TERNARY OPERATORS 2
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string results = favNum == 12 ? "You have an awesome favorite number!" : "You do not have an awesome favorite number.";

            Console.WriteLine(results);

            Console.ReadLine();
        }
    }
}
