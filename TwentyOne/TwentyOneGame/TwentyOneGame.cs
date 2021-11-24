using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TwentyOne.Interfaces;

namespace TwentyOne
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
            Dealer.Deck.Shuffle();
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
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
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
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            // The advantage of the Dealer is that they can wait to see when other players "bust". If the player busts
            // before the Dealer, that player still loses. The Dealer doesn't get their cards until all the players 
            // have their cards.
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            
            // Just like the above while loop, where as long as the Dealer says "I don't want to 'Stay'" and isn't 
            // busted, then let's continue to give them cards.
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets) // Remember 'Bets' is a dictionary table.
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    // The player is going to be in the 'entry' which is a key-value pair, and the way you access
                    // values in a key-value pair is to go 'entry.Key.Name' and 'Key' is the 'player'. Then 'entry.Value'
                    // is the value in the 'Bets' dictionary.

                    // We have to give that player their balance and their winnings, so we'll use a lambda expression to do it:
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    // So we're looping through each key-value pair, finding the 'player' in the 'Players' list that matches
                    // that key-value pair where the 'Name' equals the name in 'entry.Key.Name'.Next, we take that 'player',
                    // who is very likely the only entry on this list, by calling the 'First()' method, and we take their
                    // 'Balance' and what they bet multiplied by 2 to the 'Balance'.

                    // Then we have to take the 'Dealer' and subtract the bet from them:
                    Dealer.Balance -= entry.Value;
                }
                return; // ends the round.
            }
            // If the 'Dealer' and 'player' both 'Stay' but no one "busts" then we need a way to compare the value of both
            // the Dealer's 'Hand' and the player's 'Hand'. At that point, whoever has the highest amount wins, and if they
            // tie then they "push". 
            foreach (Player player in Players)
            {
                // There are three options for the outcome of the round: The 'player' has a greater 'Hand', the 'Dealer'
                // has a greater 'Hand', or they both tie. Usually we can use a boolean when there are just two options, 
                // but boolean actually have a third option which is 'null', that can be used when you are dealing with three
                // possible outcomes. Booleans are structs, they are a value type which means they cannot have a 'null' value.
                // However, you can make it so that a boolean is able to take a 'null' value:
                bool? playeraWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                // The question mark takes this boolean data type into a nullable boolean. In a situation like this where you
                // want to be able to assign a null' value, the .Net Framework makes it easier to work around these data type
                // restrictions.

                if (playeraWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if (playeraWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
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
