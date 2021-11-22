using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneGame
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //----------------------------------------------- FILE IO -------------------------------------------------------
            // You can also append text, which is a little bit different b/c you have to open up a "stream", which is an
            // incoming flow of bytes that is expandable. We work with streams often with images, for example, or any time
            // you don't know the final size of what you're dealing with. Logging is when you are appending some message to 
            // the end of a file.
            // Now, we will make it so that every time a 'Card' is dealt, it will be logged to the log.txt file.            

            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            // When logging, we are dealing with "streams" which is unmanaged code, and in that case you have to make sure that 
            // everything gets disposed of afterwards otherwise we'll end up running out of memory: 
            using (StreamWriter file = new StreamWriter(@"C:\Users\USER\OneDrive\Desktop\Logs\log.txt", true))
            // So we're going to be using 'StreamWriter', call it 'file', create a new 'StreamWriter' object which
            // will take the path "C:\Users\USER\OneDrive\Desktop\Logs\log.txt", and takes another argument 'true'
            // as in it's 'true' that we want to 'append'.
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            } // Once the program hits this closing bracket, then everything in the above code is all cleaned up by
              // the memory manager. This is what the 'using' statement does.
                Deck.Cards.RemoveAt(0);
            //---------------------------------------------------------------------------------------------------------------
        }
    }
}
