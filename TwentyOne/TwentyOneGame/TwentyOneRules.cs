using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // When checking for "BlackJack" we don't really want to build it into the 'Play()' method b/c that could make
    // the method even more bloated then it will already be, but in 21 there are a lot of very specific rules
    // so where would we put them? When thinking in terms of a Business Logic Layer, a layer in programming is like
    // a separate class that exists without of other classes, and it has some sort of function or feature to it
    // (i.e. a class that added things to a database and you'd call it a Data Access Layer). We're going to have 
    // a Business Logic Layer by creating a simple class called 'TwentyOneRules'. It's going to be a static class,     
    // meaning we don't have to create an object, we're just going to have a bunch of methods in it that we're going
    // to call. These methods contain logic like "check for BlackJack" or "pass in a 'Hand' and return a boolean". 
    // We're going to store these methods in one class.

    // If we can check for "BlackJack", we also need to be able to ge the value of a 'Hand', and the value of each 
    // 'Card'.
    public class TwentyOneRules
    {
        //The first thing we want to do in this class is create a dictionary of 'Card' values, and we are going to
        // make this method 'private' because this method is only going to be accessed inside this class. This is a 
        // good practice because if you mark it 'public' and someone later wanted to use that same name it could cause 
        // a conflict. And we'll make it 'static', again, b/c we don't want to have to create a 'TwentyOneRules' object
        // in order to access this method.
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        // The key is going to be 'Face' b/c values in 21 are based on the Face (i.e. a "6" has a value of 6, a "Jack"
        // has a value of 10, an "Ace" has a value of 1 or 11). A naming convention in 'private' classes is to use am
        // underscore ahead of it. '_cardValues' is going to be a new dictionary (a collection of key-value pairs) and
        // we're going to instantiate it will all of our objects b/c this dictionary of 'Cards' is never going to change.      
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1 
            // In 21, an Ace can be worth 1 or 11, but for simplicity we're just going to assign it as the value of 1,
            // b/c you can't assign more than one value to a dictionary object. We are going to do some logic later that
            // will add 10 to that. Because the player can decide whether their "Ace" is worth 1 or 11, we have to build
            // into our logic checks for "how much would this be if Ace was 1 or 11?"
        };
        // The way that we're going to determine whether or not the 'Ace' equals 1 or 11 will be by taking a 'Hand',
        // which is a list of 'Cards', and generating an array of integers of all possible values of that 'Hand'. For
        // example, the user has an 'Ace' and a 'Three': that integer array would have two  entries in it and one of them
        // would be "14" and the other would be "4". Using these numbers we could find the 'MaxValue()' or 'MinValue()', 
        // and if the minimum value is over "21" then that player "busted". This method is going to check all possible 
        // values and return an integer array:
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        // So, if the user has one 'Ace' card and another card, that 'Hand' has two possible values, one where the
        // 'Ace' is equal to "1", and the other where it is equal to "11".
        {
            // Fist, we need to find out how many aces there are, because that will determine how many values there
            // are in total:
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            // Here we used a Lambda expression (methods you can perform on lists). We're going to take each item 
            // in 'Hand' ('x') we're going to check "is the card's 'Face' equal to 'Ace'?", we're going to count it,
            // and return that count in the form of the variable 'aceCount'.

            // Once we know how many there are, we can create out 'result' which will be an integer array. Any time  
            // you create an array, you have to state how big it will be, how many possible 'results' there will be.
            // In this case, the amount of 'results' is determined by how many 'Aces' there are plus 1.
            int[] result = new int[aceCount + 1];

            // Next, we'll get the lowest possible value there is, which in this case is the default value of
            // 'Ace = 1', by using a lambda expression:
            int value = Hand.Sum(x => _cardValues[x.Face]);
            // Here, 'Sum()' takes each item 'x' and looks up it's value in the '_cardValues' dictionary and sums it.

            // Now, we'll take the first entry in the integer array '[0]' and assign it to the variable 'value'.
            result[0] = value;
            // At this point, if there are no 'Aces' then we know there is only one possible value, b/c 'Ace' is the 
            // 'Card' that has more than one value. So if there are no 'Aces' then there's only one possible value 
            // that 'Hand' could have. There would be no point in performing any more logic if there's only one value.

            if (result.Length == 1) return result;
            // So, if there is only one 'result', then the 'result' is returned, and nothing else gets executed in this
            // method.

            //Now, we'll use a for loop to iterate through the 'Aces' and assigning different values to them.
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10); //shorthand for 'value = value + (i * 10)'
                result[i] = value;
                // 'value' is the lowest possible value, with all the 'Aces' equaling "1". So to create this integer
                // array of possible values means that for each 'Ace' in the 'Hand' we make a separate value and add
                // 10 to it '(i * 10) = 10'. If there's only one 'Ace' then the first 'value' would be "1", and the second
                // value ('result') would be "1 + (1 * 10)". And if there are two 'Aces' in the 'Hand', then it would
                // be "2 + (2 * 10) = 20".
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        // This method is going to return 'true' or 'false' when checking "does this 'Hand' contain an 'Ace' and a
        // 'Face' card of 'Ten', 'Jack', 'King', or 'Queen'?" And then we are going to pass that in to a list of 'Cards'
        // called 'Hand'. 
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        // Now, we need a method for checking if the player "busted", or over 21:
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }
        
        // Next, we will create another custom method for 'Stay' b/c Dealers generally have strict rules on what they
        // can "hit" or "stay" on, usually dictated by the casino.
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            // First, we'll get the possible 'Hand' values:
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            // If the value is above 16 and below 22 the Dealer has to 'Stay', so we'll go through the possible 'Hand'
            // values and see if one of them is between 16 and 22.
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }
        // This method is going to return a nullable boolean:
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        // Remember, 'bool?' is the new data type that allows for a nullable boolean value.
        {
            // First we create an integer array of all possible player results
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            // We have two arrays, but we can't take the maximum value b/c it may be over "21", so we have to find the
            // highest value in each of these arrays that is less than 21, and then compare the two values. There are
            // two 'Hands' and each 'Hand' has several possible values depending on how many 'Aces' are present, so we 
            // need to find that possible value that is less than 22 but the highest between the two values:
            int playerScore = playerResults.Where(x => x < 22).Max();
            // So, we'll take the items ('x') in 'playerResults' where the item is less than 22 ('x < 22') and grab
            // the largest of those items ('.Max()')
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            // Now, we can compare:
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null; 
        }
    }
}
