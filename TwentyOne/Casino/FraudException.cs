using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception // We'll have this class inherit from the built-in 'Exception' class.
    {
        // We'll only have two methods in this class, and they are going to be constructors
        public FraudException()
            : base() { } //this constructor inherits from the 'base()' constructor of the 'Exception' class.
        public FraudException(string message) //overload this constructor so that it can take in a string parameter.
            : base(message) { } //pass that parameter to the base constructor, which can only take one parameter.
    }
}
