using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
        //An abstract class can not be instantiated. It's only meant to be inherited from.
        
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();//abstract methods can only exist in an abstract class
        //The inherited class must implement this method with the exact same method name, return type, and 
        //parameters.
    }
}
