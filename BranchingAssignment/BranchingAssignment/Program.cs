using System;


namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");

            Console.WriteLine("\nPlease enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine()); //Cast this variable for user input


            if (weight > 50) //Set a condition that restricts packages with a weight greater than 50 pounds
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else //If the package is less than 50 pounds, execute the next part of the program
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                int dimensionsAdd = width + height + length;

                if (dimensionsAdd > 50) //Set this condition for ensure that the items dimensions are not greater than 50
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine(); //If true, print this message and close the program
                }
                else //Otherwise use these variables to calculate the 'quote'
                {
                    int dimensionsMultiply = width * height * length;
                    int product = dimensionsMultiply * weight;
                    int quote = Convert.ToInt32(product / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quote + ".00");
                    Console.WriteLine("Thank you!");
                }
            }
            Console.ReadLine();
            
            
        }
    }
}
