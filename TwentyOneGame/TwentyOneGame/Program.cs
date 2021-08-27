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
        {
            Deck deck = new Deck();
            //We've instantiated an object called 'deck' and we've assigned it to the 
            //variable "deck." What we have here is an empty object with no values assigned
            //to it.


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
            
            Console.ReadLine();
        }
    }
}
