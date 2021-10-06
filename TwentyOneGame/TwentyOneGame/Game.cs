using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public abstract class Game
        //An abstract class is just a class marked with the keyword "abstract". This means this class can 
        //never be instantiated; it can't be an object. It's only meant to be inherited from.
        //We're never going to have an instance of 'Game'. It's always going to be a specific game (i.e. Solitare,
        //Twenty One, Poker). Game is a perfect example of a 'base' class, which another word for an abstract class.
    {

        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();
        //Abstract methods can only exist in an abstract class, and it contains no implementation. All it does
        //is state that any class inheriting this class must implement this method, like a contract between the base class
        //'Game' and the inheriting class 'TwentyOneGame'. TwentyOneGame now has to define that method somewhere in it's
        //class with the exact same name, return type, and parameters.
        
        //What if we wanted to have our own implementation of 'ListPlayers'? 
        //i.e. We want it to say "21 Players" inside of it. How would we do that when it's pretty "locked down" inside
        //of this base class? You'd use the 'virtual' keyword.
        public virtual void ListPlayers()
            //A virtual method inside of an abstract class means that this method gets inherited by an inheriting class
            //but it has the ability to override it. Virtual methods have implementation, but they can be overridden.
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
