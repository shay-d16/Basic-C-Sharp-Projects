using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        //Inheritance is one of the three pillars od Object-Oriented Programming.
        //Polymorphism (the property of classes to morph into other types of classes) is the second.

        static void Main(string[] args)

        {
            //--------------------------------------- INHERITANCE -------------------------------------------------
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            ////Through inhertiance, you are able to access to the properties and methods of the "game" object/'Game' class.
            //game.Players = new List<string>() { "Shay", "Alex", "Helayna" };
            ////We've inherited from 'Game' in the 'TwentyOneGame' class, and have access to the 'Players' property,
            ////which we've instantiated with some values.
            //game.ListPlayers();
            ////We called the 'superclass' method (a method from the class you're inheriting from).
            ////'Game' in this instance is the superclass.
            //game.Play();

            //---------------------------------------- POLYMORPHISM ------------------------------------------------
            //Game game = new TwentyOneGame();
            //This is a classic example of polymorphism. 
            //One object ('TwentyOneGame') can morph into another "higher order" object, meaning 'TwentyOneGame' 
            //inherits from 'Game.' Why would we do this instead of just writing 'TwentyOneGame = new TwentyOneGame'?
            //One reason would be if we had many different game objects, and we needed to put all of these games into
            //a list of all active games. Lists can only take one data type, so to put all these different games into 
            //list we'd use polymorphism.

            //games.Add(game);//We're able to add a 'TwentyOneGame' into a list of games.
            
            //Using polymorphism we are able to create a list of games that encompass all of our games even though
            //they were technically different data types.

            //---------------------------------------- ABSTRACT CLASSES --------------------------------------------
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Shay", "Helayna", "Alex" };
            //game.ListPlayers();
            //Console.ReadLine();

            //-------------------------------------------- INTERFACES ----------------------------------------------
            //An interface is very similar to an abstract class in that there are no implemtation details in an interface
            //So why not just use an abstract class? The biggest reason is that the .NET framework does not support 
            //multiple inheritance; meaning, one class can inherit from ONLY one other class.
            //To create an interface, right-click on the project, select "Add," choose "Class," and then "Interface."
            //The naming convention for interfaces is to start with an uppercase "I" (i.e. IWalkAway), and this is how you will be
            //able to tell that this is an interface

            Deck deck = new Deck();           

            deck.Shuffle(3);
                   
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }                                   
    }
}
