using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    public class Math
    {

        public void mathMethod(int number1)
        {
            int answer = number1 / 2;
            Console.WriteLine(number1 + " divided by 2 is " + answer);
        }

        public void mathMethod(string number2) //method overload
        {
            int answer2 = Convert.ToInt32(number2) / 2; //Convert string to integer and divide than by 2
            Console.WriteLine(number2 + " divided by 2 is " + answer2);
        }
    }

    
}
