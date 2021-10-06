using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //Right now, this class just has some properties, and we're going to add overloaded operator methods here

        
        public static Game operator+ (Game game, Player player)
        //First, we'll add the plus method, and our goal here is to make it so that we can do just 'Game + Player,'
        //and that will add the 'Player' object into the 'List<Player>' property in the 'game' object.
        //Remember, 'Game' here is the return type. Inside the parenthesis, as the parameters, are what is being
        //added together. So we are adding a 'game' and adding a 'player' and it's returning a 'game' object.
        //Ultimately, we want to affect the 'game' object and that's what we're returning. This is achieved by
        //adding in our own implementation.
        {
            //Here, we take the 'game' object that's passed in as a parameter, and adding the 'player' object to
            //the 'List<Players>' property in the 'Game' class, then returning the 'game' object.
            //So we're overloading the 'operator+,' it's taking two operands are 'game' and 'player', then it returns
            //'game.'
            game.Players.Add(player);
            return game;
           
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            //Because 'Players' is a list, we can use the .Remove() method to "subtract" this 'player' object
            //from the list and return 'game'
            return game;
        }
        //Now, we've overloaded the plus and minus operator.
    }
}
