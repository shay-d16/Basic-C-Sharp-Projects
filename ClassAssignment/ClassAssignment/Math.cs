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
            Console.WriteLine(number1 + " divided by 2 equals " + answer);

        }       

        public void mathMethod(int number2, int number3)//method overload
        {
            int answer2 = number2 + number3;
            Console.WriteLine(number2 + " plus " + number3 + " equals " + answer2);
        }


        public void OutArgMethod(out int number4, out int number5) //method with output parameters
        {
            number4 = 10;
            number5 = 2;

            int answer3 = number4 / number5;

            Console.WriteLine(number4 + " divided by " + number5 + " is " + answer3);
            
        }
    }

    
}
