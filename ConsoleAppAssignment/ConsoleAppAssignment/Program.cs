using System;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my birth month?");
            string birthMonth = Console.ReadLine();
            bool isGuessed = birthMonth == "february" ;


            do
            {
                // Switch Statements start with the word 'switch'
                switch (birthMonth)
                {
                    // Switch Statements revolve around 'cases'
                    case "january": //essentially means "if birthMonth = january"
                        Console.WriteLine("You guessed January. Try again.");
                        birthMonth = Console.ReadLine();
                        break; // You have to put 'break' otherwise the program will keep going with the switch statement
                    case "may":
                        Console.WriteLine("You guessed the month of May. Try again.");
                        birthMonth =Console.ReadLine();
                        break;
                    case "October":
                        Console.WriteLine("You guessed October.Try again.");
                        birthMonth = Console.ReadLine();
                        break;
                    case "february":
                        Console.WriteLine("You guessed the month of February. You are correct!");
                        isGuessed = true; // You need this boolean logic to let the program know this is the number it's looking for.
                        break;
                    // 'default' is used if none of the 'cases' evaluate to 'true'
                    default:
                        Console.WriteLine("Sorry, that's not it. Try again.");
                        birthMonth = Console.ReadLine();
                        break;
                }
            }

            while (!isGuessed);

            Console.WriteLine("Now that you've guessed my birth month, can you guess the day of my birthday?");
            string birthday = Console.ReadLine();
            bool guessDate = birthday == "3rd";

            while (!guessDate)
            {
                switch (birthday)
                {
                    case "14th":
                        Console.WriteLine("You guessed the 14th. Sadly my birthday is not on Valentine's Day. Guess again?");
                        birthday = Console.ReadLine();
                        break;  
                    case "29th":
                        Console.WriteLine("It would be so cool to be born on Leap Day! Sadly, you are incorrect. Guess again?");
                        birthday = Console.ReadLine();
                        break;
                    case "3rd":
                        Console.WriteLine("Wow! You guessed it! That's awesome!");
                        guessDate = true;
                        break;
                    default:
                        Console.WriteLine("You guessed wrong. Guess again?");
                        birthday = Console.ReadLine();
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
