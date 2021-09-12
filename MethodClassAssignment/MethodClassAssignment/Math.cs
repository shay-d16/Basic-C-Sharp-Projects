using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class Math
    {
        public void Display(int numA, int numB)
        {
            int math1 = numA * 10;
            Console.WriteLine(numB); 
            //Because we're just displaying the second parameter, we will use Console.WriteLine()
            //instead of return. Void methods don't return values.
        }
    }
}
