using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class TwentyOneGame : Game , IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play() 
        {
            Dealer = new TwentyOneDealer();
            // Now when we start 'game.Play()' we are going to instantiate the 'Dealer' object as a new 'TwentyOneDealer'.
            // Since we're in a while loop at this point, we don't know what stage we're at in the loop, so we want
            // to reset the all 'players'

            // This 'Play()' method is going to is play one 'Hand', and that's when while loop is happening. So at the 
            // end of the 'Hand' we're going to ask the player if they want to keep playing. If the user says "yes" then
            // then 'isActivelyPlaying' remains 'true', and if they say "no" it would be 'false'. To summarize,            
            // This new 'TwentyOneGame' 'Play()' method is going to encompass one 'Hand' of 'TwentyOne'.

            // Within the 'Game' class is the actual list of 'Players'. We have created this game so that it is capable
            // of having more than one 'player'. Again, the 'Play()' method encompasses that entire list of 'Players' in
            // the game, so when we perform an action on a 'player', we'll want to perform that same action on all the 
            // players (i.e. 'Hand').

            // So, the next thing we want to do is reset the players in this game, and we'll do this using a foreach loop:
            foreach (Player player in Players) // *Remember, 'Players' is a property of the 'Game' class*
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("PLace your bet!");

            foreach(Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                // So we're passing in the amount the player entered ('bet') to the 'Bet()' method, and if the player
                // has enough, 'successfullyBet' will be 'true'.
                if (!successfullyBet)
                {
                    return;
                    // Even though you can't usually 'return' anything in a 'void' method, 'return' by itself will
                    // basically end the method.
                }
                // Now, the 'Dealer' needs a way to track bets, especially if there are a lot of players in the game.
                // The best data type to do that is a dictionary because it is a collection oof key-value pairs, where
                // in this case the key would be 'player' and the value would be what they bet. So if we just create a 
                // dictionary object of all the bets made, when it comes time to pay everyone, we just look up their
                // name in the dictionary, see what they bet, and pay them out. We'll create it in the 'Game' class,
                // because any game inheriting from the 'Game' class would mostly likely have bets.

                // So, if 'successfullyBet' returns 'true', then we'll create a dictionary entry for the player.
                Bets[player] = bet;
                // 'Bets' represents the dictionary, 'player' is the key, and 'bet' is the value. So we now have added
                // to that dictionary the 'player' object (their name) and amount they bet.
            }
            // VIDEO FOUR: In most 21 games, the dealer cards are both face-down, or one of them is face-up. In this case,
            // we'll make them both face-up, for simplicity.
            // We'll use a for loop where we loop through the 'players' and give them a card, and we'll loop through 
            // twice. We're going have a foreach loop inside of a for loop:
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing..."); //Print this to keep track of things.
                foreach (Player player in Players) //Loop through the 'Players' list b/c we're going to 'Deal' each 'player'
                {
                    Console.Write("{0}: ", player.Name); //string formatting
                    // Write the player's name so we know who is getting dealt.
                    // 'Write()' keeps the string on the same line instead of starting a new one.

                    Dealer.Deal(player.Hand);
                    // Here, we are pasing in the player's 'Hand', it's given a 'Card', and that 'Card' is printed to the
                    // console so you can see what you're given. In BlackJack everyone can see each other's cards because
                    // they are all competing against the Dealer instead of each other, and the Dealer has ver specific rules
                    // they must follow. But the Dealer has a competitive advantage by seeing your cards.

                    // In 21, if you get an Ace and a Face card, you immediately have "BlackJack", which means in this case that 
                    // win 1 and 1/2 times your bet. So we need a way to check for that on 'Deal()'; on the second card dealt, we
                    // need to check for "BlackJack":
                    if (i == 1) // This means that this is the second turn.
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        // B/c 'CheckForBlackJack()' is a static method, dont forget to preface it with it's class
                        // name 'TwentyOneRules'
                        // Here, we are passing in the player's 'Hand' to check it for "BlackJack". 

                        // Now, we'll use some logic b/c if it is "BlackJack" then the player wins.
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);

                            // Now we will add the amount to the 'Balance'
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            // In BlackJack you win 1.5 times your bet, so we'll take the players bet, multiply it by
                            // 1.5, and then add that total to the original bet.
                            return; //Once a player gets "BlackJack" we will end the round all together.
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        
                        // Now, we have to give the dealer all the bets placed.
                        // Remember, a dictionary is essentially a list of key-value pairs, meaning you can iterate 
                        // through them.
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                            // So, we iterated through the dictionary and we assigned the 'Dealer' the balance of everything
                            //
                        }
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in Player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                        // Here, we have a 'ToString()' method that makes it so the player can see their cards in 'Hand'
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                        // Here, we 'break' the loop if the player chooses "stay" and check the while loop condition
                        // '!player.Stay'.
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }
                    }
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
