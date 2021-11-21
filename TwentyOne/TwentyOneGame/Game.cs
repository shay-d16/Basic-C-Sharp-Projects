using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public abstract class Game
    {
        // When it comes to 'List<>' you have to instantiate it or it breaks everything in the program when you
        // want to add things to it. This 'Game' class has a list of 'Players' and we want to make sure that this
        // list is never 'null' and is always at least an empty list when instantiated.
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        // This is how programmers used to write 'get; set;' which is now shorthand. This public 'Players' property,
        // in conjunction with the private '_players' property above, exposes certain ways to access the underlying
        // values in that private property. The difference in what we did  here, compared with the shorthand  
        // 'get; set;' version, is that '_players' will always equals an empty list instead of a 'null'.

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        // *Remember a dictionary takes a key and a value, the key being 'Player' and the value being the amount
        // which is an integer ('int'). We'll call this property 'Bets'

        public abstract void Play();
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
