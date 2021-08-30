using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Math
        //Create a public class called 'Math,' which is accessible everywhere in the program.
    {

        public int Divide(int numA)
            //The 'Divide' method takes in the integer type numA as it's parameter.
        {

            int mathOne = numA / 2; //the value of 'numA' divided by two is stored in the variable 'mathOne'
            return mathOne; //return the product of 'numA' divided by 2.

        }
        public int Multiply(int numB)
        {
            int mathTwo = numB * 5;
            return mathTwo;
        }

        public int Subtract(int numC)
        {
            int mathThree = numC - 8;
            return mathThree;
        }
    }
}
