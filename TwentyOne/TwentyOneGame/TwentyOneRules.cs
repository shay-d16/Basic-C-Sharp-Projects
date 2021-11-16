using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
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
    }
}
