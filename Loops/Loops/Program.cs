using System;


namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            // The issue with the 'while loop' is that if the first answer evluates to 'true' (in this case,
            // if you guessed the correct number on the first try), then the while loop is never run.
            // You will want the program to run the while loop at least once. Because this is a common issue,
            // C# has created a solution in the form of 'do-while loop.'

            do
            {
                // Switch Statements start with the word 'switch'
                switch (number)
                {
                    // Switch Statements revolve around 'cases'
                    case 62: //Which essentially means "if number = 62"
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break; // You have to put 'break' otherwise the program will keep going with the switch statement
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55.Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. you are correct!");
                        isGuessed = true; // You need this boolean logic to let the program know this is the number it's looking for.
                        break;
                    // 'default' is used if none of the 'cases' evaluate to 'true'
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed); // Putting the '!' before 'isgGuessed' reads as "while isGuessed = false..."
            // Without a 'while loop,' you would have to keep running this switch statement again and again to guess a 
            // different number. The while loop makes it so that the program continues
            // to run until you guess the right number.
            
            // the 'do-while loop' ensures that the while loop is run at least once.
          
            // Between the 'while loop' and the 'do-while loop,' you'll very likely be using
            // the 'while loop' much more often than 'do-while.'

            // It's sometimes better to avoid using 'while loops' because they can create
            // what's known as an "endless loop," which can happen if the expression in the loop
            // (i.e. '!isGuessed') can never evaluates to 'false,' or never evaluate to 'true.'
            // This causes the program to run forever, which is not what you want to happen in 
            // your program. This is why important to only use a while loop if there are no other
            // options.

            Console.ReadLine();

        }
    }
}
