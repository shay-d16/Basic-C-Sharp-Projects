using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card      
    {       
        public Suit Suit { get; set; }       
        public Face Face { get; set; }

        // Every class has a built-in method that's part of the .Net Framework which is called 'ToString()' and it has
        // it's own implementations, but when it comes to custom objects often times doesn't work the way you want it to.
        // Luckily, you can override the 'ToString()' method:
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
            // So now when we call 'card.ToString()' it prints to the console a "King of Hearts" or "Two of Spades,
            // for example.
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two, 
        Three, 
        Four, 
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
