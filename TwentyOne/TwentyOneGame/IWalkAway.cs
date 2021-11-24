using System;
//using TwentyOne.Interfaces;

//namespace TwentyOne.Interfaces
namespace TwentyOne
{
    //Let's say that this 'TwentyOneGame' is subject to the Nevada State Gaming Comission, which has some obscure law that
    //States that every game involving gambling must have a way for the individual to "stand up and walk away"; there must 
    //some way for the user to "stand up and walk away" with their remaining balance. The game or casino can't hold the person's
    //money hostage for a certain amount of time and forcing that person to gamble more. Let's just say that's a regulation
    //and you need some way of supporting that in your code.
    //If we added this WalkAway method as an abstract class to the 'Game' class, then it would have to be implemented in every
    //inheriting class. Solitaire, for example is a non-betting game so it wouldn't make sense to have to implement a 'WalkAway'
    //method in that class.
    //The .NET Framework supports multiple inheritance of interfaces. You can only inherit one base class, but you can also 
    //inherit as many interfaces as you want. 
    interface IWalkAway
    {
        //Everything is 'public' in an interface, so you don't need a 'public' keyword for the methods.
        void WalkAway(Player player); 
        //Now any class that inherits from 'IWalkAway' HAS to implement this method, with the same parameters and a void
        //return-type.
    }
}   
