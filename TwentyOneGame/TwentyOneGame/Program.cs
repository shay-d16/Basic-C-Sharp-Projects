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
            // Through inhertiance, you are able to access to the properties and methods of the "game" object/'Game' class.

            //game.Players = new List<string>() { "Shay", "Alex", "Helayna" };
            // We've inherited from 'Game' in the 'TwentyOneGame' class, and have access to the 'Players' property,
            // which we've instantiated with some values.

            //game.ListPlayers();
            // We called the 'superclass' method (a method from the class you're inheriting from).
            // 'Game' in this instance is the superclass.
            //game.Play();

            //---------------------------------------- POLYMORPHISM ------------------------------------------------
            //Game game = new TwentyOneGame();
            // This is a classic example of polymorphism. 
            // One object ('TwentyOneGame') can morph into another "higher order" object, meaning 'TwentyOneGame' 
            // inherits from 'Game.' Why would we do this instead of just writing 'TwentyOneGame = new TwentyOneGame'?
            // One reason would be if we had many different game objects, and we needed to put all of these games into
            // a list of all active games. Lists can only take one data type, so to put all these different games into 
            // list we'd use polymorphism.

            //games.Add(game);//We're able to add a 'TwentyOneGame' into a list of games.

            // Using polymorphism we are able to create a list of games that encompass all of our games even though
            // they were technically different data types.

            //---------------------------------------- ABSTRACT CLASSES --------------------------------------------
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Shay", "Helayna", "Alex" };
            //game.ListPlayers();
            //Console.ReadLine();

            //-------------------------------------------- INTERFACES ----------------------------------------------
            // An interface is very similar to an abstract class in that there are no implemtation details in an interface
            // So why not just use an abstract class? The biggest reason is that the .NET framework does not support 
            // multiple inheritance; meaning, one class can inherit from ONLY one other class.
            // To create an interface, right-click on the project, select "Add," choose "Class," and then "Interface."
            // The naming convention for interfaces is to start with an uppercase "I" (i.e. IWalkAway), and this is how you will be
            // able to tell that this is an interface

            //----------------------------------------- OPERATOR OVERLOADING ------------------------------------------
            // Method overloading is when you can make a method with the same name but different signature (i.e. taking
            // a different number of parameters or return a different data type), and this same thing can be done with
            // operators (like +, -, *, /). Why would you want to overload an operator? Why would you want to make your
            // own implementation of + or - when they already seem pretty straight forward?
            // In this case, the operators would be specific to an object you've created. For example, what if you wanted 
            // to add two objects together? Or if you just wanted to use the plus sign to add a 'Player' to the game?

            //// Game game = new TwentyOneGame();
            // We're actually using polymorphism again here, becuase notice that 'Player' returns a 'game.' We're enabling
            // the ability to add a 'player' to a 'game,' and because we're using 'Game' and not 'TwentyOneGame' this 
            // overloaded operator will work even if later down the road we create a 'PokerGame' or 'SolitaireGame' we can
            // still use the plus operator to add a 'player' to that game. This is polymorphism at work.

            // When we try to run the program without this next line of code, we get an 'Exception Unhandled' error message 
            // that states: "System.NullReferenceException: 'Object reference not set to an instance of an object.' 
            // TwentyOne.Game.Players.get returned null."
            // This is because the 'Game' class has this 'List<Player>' property, and lists HAVE to be instantiated
            // first. You have to CREATE a list before you can add to it. We have this 'TwentyOneGame' class which
            // inherits from the 'Game' class, and therefore has the 'List<Player>' property, yet we are trying to add
            // a 'player' to a list that hasn't been instantiated. So we'll add:

            ////game.Players = new List<Player>();
            // Now, we've instantiated the list and can add 'players' to it.

            //// Player player = new Player();
            //// player.Name = "Shay";

            //// game = game + player;
            // The short-hand way to write this is: 'game += player'

            // Remember, the parameters are a 'game' and a 'player' and it returns a 'game.' So this in a way is our 
            // method
            // Instead of commenting out the bottom code, just set a breakpoint at 'Deck deck = new Deck();' so the 
            // program will stop running at that point so that we can examine these above variables

            //// game = game - player; 
            // short-hand: 'game -= player'

            //------------------------------------------- GENERICS ------------------------------------------------
            // Definition (dictionary): Belonging to a group of things, but not specific. In programming languages, 
            // generics are a feature of the language that allows you to write generic classes or generic functions, 
            // functions that by nature are more generalized and less specific. This is the direction you want to go in
            // programming; the more generic you can make something, the more reusability we have.
            // We've actually been using generics every time we use the 'List<>' data type. When we define a List's
            // data type between the angle brackets, it is the TYPE of data that the List is containing. When you type 
            // the data type, suddenly that 'List<>' class adapts itself to that data type; and the way that's done is
            // in the definition of 'List<>' class. Instead of hard coding a data type C# just uses "List<T>," and that
            // "T" represents the data type that will be passed in upon object creation. When this 'List<T>' class is 
            // instantiated you pass in the data type where "T" is and you can now have a list that holds a data type
            // that is unknown to the class. And that's the idea of generics, this 'List<T>' is now usable for EVERY 
            // kind of data type, whereas if we had to hard code 'List<string>' or 'List<int>', we'd have to make a new 
            // class for every single one. That is the advantage of generics.

            // After making the 'Player' class and 'Hand' property generic, we can now create a 'player' object, we can
            // pass in the data type that we want the 'Hand' to hold

            //// Player<Card> player = new Player<Card>();
            //// player.Hand = new List<Card>();

            // The most common usage of generics that you will find in programming will be inside of the List class.
            // Generic is a concept where you can pass in a data type on creation and it effects the rest of the class.
            // So it's just one more way of abstracting your code to encompass more situations, whic results in more 
            // code use and better adaptability.  

            //---------------------------------------------- ENUMS -----------------------------------------------------
            //  When you say that a piece of data is of type "enum" you're saying that it is one in a set of named
            // constants. A common example of this is you could create an "enum" for the days of the week, and it would
            // only have seven possible values. In this case, if I wanted to create a variable 'day' and assign it a value, 
            // it would have to be just ONE of the seven values. Enums limit the possible values that you can receive from 
            // a user. For example, if you have a dropdown list of a set number of items like 'DaysOfTheWeek' and user has 
            // to choose a day, which you have made an enum type. Then you know that no value will be assigned to that 
            // variable unless it is one of those items, and that completely eliminates the possibility of a user input error
            // on that step. Even though it seems like a small thing, it does relieving because it's one less thing you have to 
            // worry about in you program.

            //// DaysOfTheWeek day = DaysOfTheWeek.Monday;

            // Another advantage of enums is that Visual Studio has intellisense for them. When you press "dot," Visual
            // Studios will show you your options, which makes programming far easier.

            // Days of the week is pretty easy to remember but what if we're dealing with something different?
            // A 'Console' application has a data type called 'ConsoleColor' so to assign a 'ConsoleColor' you'd type:

            //// ConsoleColor color = ConsoleColor.Cyan;

            // Again, a dropdown list of all possible values will appear when you type "dot" after the data type.
            // And then you don't have to worry about anything but choosing whichever option is available. The designer
            // of this 'ConsoleColor' class doesn't have to wonder about if the user chose the right color or a color
            // that's supported because they can only choose one of the values present.

            //  After making the 'Suit' property into an enum, you can instantiate a new card, and select one of the 
            // four options available (Hearts, Diamonds, Clubs, Spades). We can't give the 'Suit' property any other
            // value than one of the four possible values. So making this property an enum limits the program but also
            // protects it from errors. 

            //  While this code is properly written, and the 'Suit' property should rightfully be an enum type, it's 
            // important to note that in this specific example, changing the property to an enum mid-stream like this
            // is definitely breaking other parts of the program.
            
            //// Card card = new Card();
            //// card.Suit = Suit.Hearts;
            // Enums have an underlying data type. On the surface, our enum is called 'Suit' and it has a string value.
            
            //// int underlyingValue = (int)Suit.Diamonds;
            // What we did here was we casted 'Suit.Diamonds' to an integer.
            
            //// Console.WriteLine(underlyingValue);
            
            // When you run this, the integer "1" is printed to the console. Inside of an enum the underlying value is
            // assigned in order and it starts with 0. 'Clubs' has a value of 0, 'Diamonds' has a value of 1, 'Hearts'
            // has a value of 2, and 'Spades' has a value of 3.
            // We could actually assign any value we want to these 
            // properties. For example, we could type 'Clubs=4, Diamonds=10, Hearts=12, Spades=15'. Some of the reasons
            // for setting the values this way, i.e. if you wanted to compare different values of enums.
            // Another example would be like a computerized stove with 'Low, Medium, Hot': you would want to know that 
            // 'Hot' is greater than 'Medium'. Having underlying value (or underlying data of 'int') allows you to 
            // compare the values in a very specific and exact way.

            Deck deck = new Deck();           

            deck.Shuffle(3);
                   
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();            
        }
        //-------------------------------------------- ENUMS (Continued) ----------------------------------------------
        //public enum DaysOfTheWeek
        //{
        //    //You don't have to use quotes
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
    }
}
