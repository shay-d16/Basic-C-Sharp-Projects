using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Deck
    {
        public Deck()
        //Constructors always go at the top of the class, before the properties.
        //Remember a constructor is a way of assigning values to an object immediately
        //upon creation.
        {
            Cards = new List<Card>();
            Card cardOne = new Card();
            cardOne.Face = "Two";
            cardOne.Suit = "Hearts";
            Cards.Add(cardOne);
        }
        
        public List<Card> Cards { get; set; }
    }
}
