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
        {
            //1. The first thing a constructor does is instantiate it's property 'Cards'
            // as an empty List of 'Cards.'
            Cards = new List<Card>();
            //'Cards' is referring to the property of the 'Deck' class, which is why we don't
            //need to put a data type ahead of it or give it a variable name because it already
            //has one; it is a property of that 'Deck' class or object that we created.

            //2. Then it creates two more Lists and immediatedly instantiates them with values.

            //We know that a deck of cards has 13 "Faces" of cards and 4 Suits, which
            //total out to 52 cards. The first thing we have to do is create a list
            //of all the possible Suits.

            //// List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };

            //Now we'll create another list of type 'string' called 'Faces' and instantiate it 
            //// List<string> Faces = new List<string>()
            //{
            //    "Two", "Three", "Four", "Five", "Six", "Seven",
            //    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            //};


            //foreach(string face in Faces)
            //{

            //foreach(string suit in Suits)

            //{
            //    Card card = new Card();
            //    card.Suit = suit;
            //    card.Face = face;
            //    Cards.Add(card);                 
            //}
            //    }
            //--------------------------------------------- ENUMS --------------------------------------------------
            //  Renember, the above 'public Deck()' is our constructor. When we instantiate a new 'Deck' 
            // ('Deck deck = new Deck();'), it also creates a new list of 'Cards' we can add to
            // ('Cards = new List<Card>();).

            // Here, we are going to do some for loops instead of foreach loops. Because enums have an integer as their 
            // underlying data type, we'll be able to access those as a reference point.

            for (int i = 0; i < 13; i++)
                // Recap on 'For Loops': we start with the value 'i = 0;' and we will run this loop as long as 'i' is 
                // less than 13. Once 'i' equals 13, the loop will stop. After each for loop, we increment 'i' by 1.

                // We had a nest for loop before, and we are going to do something similar here. We want to loop
                // through all 'Faces' and for each 'Face' we're gonna loop through each 'Suit' because each 'Face' 
                // has 4 instances of it, and it's a different 'Suit' each time. So we're doing two for loops here.
            {
                for (int j = 0; j < 4; j++)
                // We're using 'j' instead of 'i' here because we are already defining 'i'.
                // This is going to run a total of 52 times. And for each of these 52 loops, we are going to create a
                // new 'Card' because there are 52 cards in a deck, so this we create a card 52 times.
                {
                    Card card = new Card();
                    // So far, we've been able to cast an enum like 'Suit.Clubs' to an integer. In the same way, we 
                    // can also cast an integer to an enum:
                    card.Face = (Face)i;
                    // This is one way of casting, by putting the data type you're casting to ('Face') inside the
                    // parenthesis. Then we cast 'i', which is an integer, to 'Face'. At first, 'i' is 0. The value
                    // at index 0 of the 'Face' enum is "Two".
                    card.Suit = (Suit)j;
                    // Here, we are casting 'j' to 'Suit' because we are assigning the 'Card' a 'Suit'
                    Cards.Add(card);
                    // Here, we want to add this 'card' to the 'Cards' list. 
                    
                    // This is an easy way to very quickly create a 'Deck' of 'Cards'.
                    // So, this loop will happen 52 times: It creates a 'Card', assigns that 'Card' a 'Face' based on
                    // the the loop number it's currently executing which is the value of 'j'. Remember each with each
                    // 'card' there are only four possible values.
                }
                
            }
        }        
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            
            for (int i = 0; i < times; i++)
            {                
                List<Card> TempList = new List<Card>(); //right now this list is empty.

                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    //'random.Next' takes a minimum and maximum value, which in this case is 0 - 52.
                    TempList.Add(Cards[randomIndex]);
                    //We'll add the randomIndex to our Temporary List. Remember the [randomIndex]
                    //is a 'zero based index.'
                    Cards.RemoveAt(randomIndex);          
                }
                Cards = TempList;
            } 
        }
    }
}
