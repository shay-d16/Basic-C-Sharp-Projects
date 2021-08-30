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
        //upon creation. So this method is called as soon as an object is created.
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
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };

            //Now we'll create another list of type 'string' called 'Faces' and instantiate it 
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //3. We end up with two Lists: One with 4 values, and the other with 13.

            //Instead of listing every single card in the deck one by one, we will use
            //a 'nested' foreach loop. For each 'Face' in that list of 13, we need to loop
            //through it 4 times, once for each 'Suit.' The idea is to loop through both of these 
            //lists in order to generate a deck of 52 cards, one of each combination.

            //4. For each of the items in the first List 'Faces,' we loop through 4 times.
            foreach(string face in Faces)
            {
            
                foreach(string suit in Suits)
                //So for each item in the 'Faces' List, we will loop through the items in the
                //'Suits' List.

                //5. During each loop, we create a 'card' and we assign the 'Suit' property the 
                // value of 'suit.'
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                 //6. We add the new card we created into the 'Cards' List at the top (line 18). 
                 //7. The 'card' variable only exists inside of each loop. Once the loop
                 // ends, the 'card' variable doesn't exist anymore.
                }
            }
        }
        
        public List<Card> Cards { get; set; }
    }
}
