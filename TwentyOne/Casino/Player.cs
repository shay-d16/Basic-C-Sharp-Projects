using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace TwentyOne
namespace Casino
{
    public class Player
    {
        // This is a constructor that takes two parameters and assigns some values.
        public Player(string name, int beginningBalance)
        {
            //When the constructor is instantiated, it will first create an empty list 'Card' to add values to. 
            Hand = new List<Card>();
            //Then it will assign the above parameters to these properties in the class, the 'Player' object:
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }

        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount; //This is shorthand for 'Balance = Balance - amount'
                return true;
            }
        }
        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;

        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}