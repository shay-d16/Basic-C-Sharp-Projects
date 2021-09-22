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
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };

            //Now we'll create another list of type 'string' called 'Faces' and instantiate it 
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

          
            foreach(string face in Faces)
            {
            
                foreach(string suit in Suits)
                
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);                 
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
