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
            TwentyOneGame game = new TwentyOneGame();
            //Through inhertiance, you are able to access to the properties and methods of the "game" object/'Game' class.
            game.Players = new List<string>() { "Shay", "Alex", "Helayna" };
            //We've inherited from 'Game' in the 'TwentyOneGame' class, and have access to the 'Players' property,
            //which we've instantiated with some values.
            game.ListPlayers();
            //We called the 'superclass' method (a method from the class you're inheriting from).
            //'Game' in this instance is the superclass.
            game.Play();
         


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
