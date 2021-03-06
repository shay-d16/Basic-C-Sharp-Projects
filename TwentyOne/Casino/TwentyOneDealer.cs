using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace TwentyOne
namespace Casino.TwentyOne
{
    public class TwentyOneDealer : Dealer // Now 'TwentyOneDealer' can inherit from 'Dealer'
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }

        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
