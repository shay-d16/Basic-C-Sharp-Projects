using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math
    {
        public int Add(int numA)
        {
            int math1 = numA + 56;
            return math1;
        }

        public int Decimal(decimal numB)
        {
            decimal math2 = numB - 2;
            return (int)math2; //The (int) is used to cast the decimal into an integer.
        }

        public int myString (string numC)
        {
            int math3 = Convert.ToInt32(numC) * 23; //cast the string value to an integer.
            return (int)math3;
        }
    }
}
