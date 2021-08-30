using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
            //'Methods,' also known as 'functions' or 'routines,'are little blocks of reusable
            //code that do something. They are composed of an 'access modifier,' which comes first,
            //and it basically establishes whether or not the method is accessible everywhere within
            //within the program or just within the class.
            //Along with an 'access modifier, a method also has a 'return' type (i.e. void), as well
            //as parameters (or lack thereof). Above, the 'Main()' method takes a string array (string[]) 
            //called 'args' as a parameter.
            //Methods have to be part of a 'class.' If a method is being used without first creating an 
            //object of that class, then it has to be marked 'static.'

            //In our instantiation of the 'Deck' class into the 'deck' object, we now have a deck of cards
            //perfectly in order. Let's create a method that shuffles the cards, since this is something
            //a dealer would do quite a bit to prevent cheating. We'll make it a method so the dealer can 
            //call upon it to shuffle whenever they feel like it.

            //We want a method that takes a List of cards and 'returns' a shuffled deck of cards. So 
            //our method would have a 'return' type of 'Deck'; it would also take a 'deck' as a 
            //type of 'argument.' So we take in a 'deck' and return a 'Deck' (See Line 81).
        {
            Deck deck = new Deck();
            //We've instantiated an object called 'deck' and we've assigned it to the 
            //variable "deck." What we have here is an empty object with no values assigned
            //to it.

            ////Now, upon instantiating the 'deck' object, which has a property 'Cards,'
            ////the 'Cards' List should have 52 'Cards' in it, one of each card in a standard 
            ////deck of cards.

            int timesShuffled = 0;

            deck = Shuffle(deck, out timesShuffled, 3);
            //deck = Shuffle(deck); 
            //This takes the 'deck' as a parameter, and returns a 'deck,' reassigning it to that
            //variable. (See Line 118).

            //----------------------------------------------------------------------------------------
            //deck.Cards = new List<Card>();
            //deck has a property called 'Cards' which is of data type List<Card>, and in 
            //order to assign anything to a List you must first instantiate it with the 'new'
            //keyword. Now we can Add 'Cards' to this property of the 'deck' called "Cards."

            //Card cardOne = new Card();
            //Here we instantiated an object of data type 'Card' assigned to the
            //variable 'cardOne.' Right now this object is empty, there are no values
            //assigned to it.

            //cardOne.Face = "Queen";
            //We've assigned the string "Queen" to the property 'Face' of the object 'cardOne.'

            //cardOne.Suit = "Spades";
            //If you were to create a new 'Card' but not assign any values to it, the 'constructor'
            //will assign default values that are given to the object.

            //deck.Cards.Add(cardOne);
            //Now we've added one card to the deck. To fill up this deck one by one would take a 
            //lot of time and typing, which brings us back to the 'constructor.' The 'Card' class may
            //not need a contructor, but the 'Deck' class certainly will.

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //----------------------------------------------------------------------------------------

            ////In order to print all the cards to the console so that we can see it, we have 
            ////to create another foreach loop.            
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times Shuffled: {0}", timesShuffled);//{0} is for the assigned variable 'timesShuffled'
            Console.ReadLine();
        }

        //Write this method below the 'Main' method.
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //We first write 'public' to make the method accessible everywhere, 'static' because
        //we don't want to have to create an object Program before calling this method, 'Deck'
        //which is the type of data it's returning, 'Shuffle' is the name of the method, and
        //'Deck deck' is the paramters for the data type and it's variable name.
        //Shuffling is supposed to be random, different each time. C# has a 'Random' class
        //for this instance.
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                //Before the 'random' object, we're going to create a temporary List where we are
                //going to store our shuffled items:
                List<Card> TempList = new List<Card>(); //right now this list is empty.

                Random random = new Random();
                //The object 'random' now has methods associated with it (i.e. we could write 
                //'random.Next' which would give us a random number between certain integers that we
                //wanted).

                //Next we'll create a while loop
                while (deck.Cards.Count > 0)
                //The idea here is that we are going to grab a random card, take it out of the 
                //deck and put it into a temporary deck. We are going to do that until
                //'deck.Card.Count reaches 0, which is when the while loop ends.
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    //'random.Next' takes a minimum and maximum value, which in this case is 0 - 52.
                    TempList.Add(deck.Cards[randomIndex]);
                    //We'll add the randomIndex to our Temporary List. Remember the [randomIndex]
                    //is a 'zero based index.'
                    deck.Cards.RemoveAt(randomIndex);
                    //'.RemoveAt' is a function of the List method. Here, we added it to the Temporary
                    //List and deleted it from the List of 'Cards,' which we do until there are no cards
                    //left.
                }
                //Then we take our 'deck' of 'Cards,' which is now empty and we assign the 'TempList' to
                //it as a value, and we 'return' the deck.
                deck.Cards = TempList;
            }
            return deck;
            //This is the method, but now we have to 'call' this method (See line 40).
        }
        //"Method overloading" is the term for being able to create multiple methods with the same name as 
        //long as they are slightly different.

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
