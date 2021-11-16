using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; }
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
