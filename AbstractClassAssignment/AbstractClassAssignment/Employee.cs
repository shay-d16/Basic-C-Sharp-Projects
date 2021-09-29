using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person //To inherit from another class all you need to do is to type in a
    //colon and the name of the class you're inheriting from.    
    {
        //In order to implement the abstract class in the inherited class, you must add the 'override' keyword.
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
