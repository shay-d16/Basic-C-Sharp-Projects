using System;


namespace ComparisonOperatorAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //Print this line at the top of the console.

            //PERSON 1
            Console.WriteLine("\nPerson 1:");
            Console.WriteLine("Hourly Rate?");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int week1 = Convert.ToInt32(Console.ReadLine());

            //PERSON 2
            Console.WriteLine("\nPerson 2:");
            Console.WriteLine("Hourly Rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int week2 = Convert.ToInt32(Console.ReadLine());

            //ANNUAL SALARY
            int salary1 = rate1 * week1 * 52;
            Console.WriteLine("\nAnnual salary of Person 1:");
            Console.WriteLine(salary1);

            int salary2 = rate2 * week2 * 52;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);

            //COMPARISON
            bool compareSalaries = salary1 > salary2;
            Console.WriteLine("\nDoes Person 1 make more than Person 2?");
            Console.WriteLine(compareSalaries);



            Console.ReadLine();

            
        }
    }
}
