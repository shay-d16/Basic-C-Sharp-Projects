using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Card //This makes the Card class accessible to the Program class
    {
        public Card()
        //This is a 'constructor' and it's value is assigned to an object upon creation.
        //The contructor method name is always the name of the class, which is how C# knows
        //that it's a 'constructor.'
        {

        }
        public Suit Suit { get; set; }
        // Enums: You can change the data type of the Suit property from 'string' to 'Suit' to reflect
        // that this property has changed into an enum.
      


        ////public string Suit { get; set; }
        //  This says the Card class has a property of the stat type string called Suit,
        // and you can 'get' this property or you can 'set' this property. By making this property
        // 'public' means that it is accessible to other parts of the program. We want to be able to
        // use this property in our Program class.
        
        public string Face { get; set; }
        //  A class is just a model or design for an object. In this case, if we assign a Suit to a Card
        // in our program we are not giving the Suit value to the Card class. The class is just a design
        // for the property. Instead we are going to give that value to an object that is modeled after 
        // this class.        
    }
    //-------------------------------------------- ENUMS ------------------------------------------------
    //  One of the most "obvious" candidates to be an enum is our 'Suit' property in our 'Card' class.
    // The thing about the 'Suit' property is that there is always only 4 possible values. If we 
    // added a feature later where a user would enter a card 'Suit' or it was read from another source
    // (i.e. API), then any misspellings or mistypes of those 'Suit' names would break our code. So by
    // changing it to an enum we would eliminate all those possible mistakes. 

    //  When you define an enum, it's similar to defining a class. Normally when you define a class, you
    // have to create a separate file for it. However, this enum specifically relates to the 'Card' class,
    // so it would beneficial in this case to define it below the 'Card' class. That way, it's easily 
    // accessible. 
    
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}
