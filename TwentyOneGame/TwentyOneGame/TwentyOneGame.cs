using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //To inherit from another class all you need to do is to type in a colon and the name of the class 
    //you're inheriting from.
    public class TwentyOneGame : Game , IWalkAway
    {
        //Because 'TwentyOneGame' is inheriting from 'Game', we have to implement the abstract method Play()
        public override void Play() 
            //In order to implement the abstract method in the inherited class, you define the same method 
            // 'void Play()' but use the 'override' keyword, and that will satisfy the "contract"
        {
            //Since we don't yet want to add any implementation to this method. We are creating this method
            //just to show that we can create a method that's specific only to 'TwentyOneGame' and not 'Game.'
            //We don't this method called, and if it is, we'll just throw an error, like so:
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();//This is equivalent to the 'ListPlayers()' block of code in the 'Game' class.
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
