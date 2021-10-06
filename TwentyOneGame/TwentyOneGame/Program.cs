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

            //----------------------------------------- OPERATOR OVERLOADING ------------------------------------------
            //Method overloading is when you can make a method with the same name but different signature (i.e. taking
            //a different number of parameters or return a different data type), and this same thing can be done with
            //operators (like +, -, *, /). Why would you want to overload an operator? Why would you want to make your
            //own implementation of + or - when they already seem pretty straight forward?
            //In this case, the operators would be specific to an object you've created. For example, what if you wanted 
            //to add two objects together? Or if you just wanted to use the plus sign to add a 'Player' to the game?
            
            Game game = new TwentyOneGame();
            //We're actually using polymorphism again here, becuase notice that 'Player' returns a 'game.' We're enabling
            //the ability to add a 'player' to a 'game,' and because we're using 'Game' and not 'TwentyOneGame' this 
            //overloaded operator will work even if later down the road we create a 'PokerGame' or 'SolitaireGame' we can
            //still use the plus operator to add a 'player' to that game. This is polymorphism at work.

            //When we try to run the program without this next line of code, we get an 'Exception Unhandled' error message 
            //that states: "System.NullReferenceException: 'Object reference not set to an instance of an object.' 
            //TwentyOne.Game.Players.get returned null."
            //This is because the 'Game' class has this 'List<Player>' property, and lists HAVE to be instantiated
            //first. You have to CREATE a list before you can add to it. We have this 'TwentyOneGame' class which
            //inherits from the 'Game' class, and therefore has the 'List<Player>' property, yet we are trying to add
            //a 'player' to a list that hasn't been instantiated. So we'll add:
            game.Players = new List<Player>();
            //Now, we've instantiated the list and can add 'players' to it.
            Player player = new Player();
            player.Name = "Shay";
            
            game = game + player;
            //The short-hand way to write this is: 'game += player'

            //Remember, the parameters are a 'game' and a 'player' and it returns a 'game.' So this in a way is our 
            //method
            //Instead of commenting out the bottom code, just set a breakpoint at 'Deck deck = new Deck();' so the 
            //program will stop running at that point so that we can examine these above variables
            game = game - player; //short-hand: 'game -= player'


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
