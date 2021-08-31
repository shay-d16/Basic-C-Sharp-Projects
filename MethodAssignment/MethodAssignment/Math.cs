using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Math
    {
        public int Multiply(int numA, int numB = 14) 
            //This method will take two integer type parameters, one of which has a default value of 14.
        {
            int math1 = numA * numB;//store the value of 'numA' multplied by 'numB' in the variable 'math1'
            return math1; //return that value
        }
    }
}
