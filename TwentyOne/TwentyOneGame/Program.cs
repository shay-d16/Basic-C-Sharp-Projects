using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------- FILE IO ---------------------------------------------------
            // In this section, we will discuss how to write and read text to and from a text file. One of the most
            // common uses of writing or reading anything from a text file would be "logging", which is when you
            // put in a meaningful entry into a file or database based on an action of the program. Some programs 
            // will log every method call if they really want to track everything, others will log just the errors.
            // Right now, we're going to add logging on every card dealt to a text file.
            // The 'File' class exists in the 'System.IO' namespace.

            //string text = "Here is some text";
            //File.WriteAllText(@"C:\Users\USER\OneDrive\Desktop\Logs\log.txt", text);
            // 'File.WriteAllText()' takes in an argument of the path of the file and the 'text' you want written in
            // it. The '@' symbol just means to read this string exactly as it is, otherwise you would have to add
            // double backslashes, one of which is an escape character.

            //string text = File.ReadAllText(@"C:\Users\USER\OneDrive\Desktop\Logs\log.txt");
            // Now when you run the program an hover over 'text' you'll see the "Here is some text." from the text file.

            //----------------------------------------- DATETIME -------------------------------------------------
            // A 'DateTime' is a value type, as well as a struct, meaning it's not nullable. 
            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
            // When you run the code to this point and hover over 'ageAtGraduation', you'll find '{6584.08:01:37}' in 
            // {days.hours.milliseconds.minutes}. 'TimeSpan' is just an easy way to compare two dates.

            // The first thing that we want to happen in this program is to print a welcome message to the user.
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine(); 
            // user inputs their name and it is stored in the variable 'playerName'.
                                                    
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine()); 
            // take the user input (integer), convert it to a string, and assign it to the variable 'bank'.

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            // Here, we used string formatting where we put a variable placeholder in curly braces (think "wildcard"),
            // with 'playerName' being the variable to take it's place. 
            string answer = Console.ReadLine().ToLower();
            // converting the 'answer' given by the user to lower case using 'ToLower()' makes it easier to check
            // against.
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                // If the user wants to play, let's create a 'Player' object, and let's initiate the object with the
                // user's name and how much money they brought.
                Player player = new Player(playerName, bank);
                // *Remember that the 'Player' object takes in two parameters.

                Game game = new TwentyOneGame();
                // polymorphism at work here. We do this to expoze the overloaded operators in the 'TwentyOneGame' 
                // class, which inherits from the 'Game' class.
                game += player; 
                // This adds the 'player' to the 'game'.
                player.isActivelyPlaying = true; 
                // 'isActivelyPlaying' is a bool property in the 'Player' class that we can use in a while loop which
                // will state that while the player 'isActivelyPlaying' play the game.
                while (player.isActivelyPlaying && player.Balance > 0)
                    //This loop checks that the player wants to play AND they have enough money to play. 
                    //If both conditions are met, this loop will continue to run.
                {
                    game.Play();
                    // 'game.Play()' is going to to play one 'Hand', and this while loop is going to loop through 
                    // again and again as long as the player 'isActivelyPlaying' and their 'Balance' is greater than 0.                    
                }
                // If the user exits the while loop, we'll want to subtract them from the game.
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            // If the user didn't answer "yes" this message will print:
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            // This saves us from having to write an else statement when we don't need it which makes the code cleaner.
            // If the user answers "no" it will skip the 'if' statement and jump straight to end, here:
            Console.Read();
        }
        // This is the entirity of the 'Main()' method. Everything else that happens in this game is going to happen
        // "below the surface", which is what we want because we don't want too much going on in the 'Main()' method.
    }
}
