using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        //We are giving this 'Dealer' class which is going to be a 'dealer' object the ability to 'Deal'.
        //In other words, it takes as an input parameter a list of cards (Hand) and in this method is going to
        //add a card to that Hand, which is why it's taking in Hand as an input parameter.
        {
            Hand.Add(Deck.Cards.First());
            //Remember 'Hand' is a list, so it has the built in method .Add() to add something to the list.
            //'Deck' is composed of a list of 'Cards'
            //.First() is a method available to a list which takes the very first item in that list. So in the 
            //code above, we take the first card and we add it to the 'Hand' that is passed in to 'Deal()',
            //then we print which card was dealt to the console so the user sees which card was dealt.
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");

            //So now we've added it to the 'Hand' but we haven't removed it from the 'Deck'
            Deck.Cards.RemoveAt(0);
            //.RemoveAt is a method that any list has where you pass in an index of where you want to remove

            //So why don't we have the Dealer class inherit from the Deck class as opposed to adding it in as a property 
            //above? The reason why we aren't doing that is because inheritance is an "is-a" relationship, not a "has-a"
            //relationship. In other words, a 'TwentyOneGame' IS a game, but a 'Dealer' HAS a 'Deck' instead of being a 
            //TYPE of 'Deck'. Therefore, you would not inherit from it. Similarly, 'TwentyOneGame' does not HAVE a game,
            //it IS a game.
        }
    }
}
