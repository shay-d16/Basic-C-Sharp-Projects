using System;


namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

                // Hold down CTRL + K + C to simultaneously comment
                // a highlighted block of code.

            //Console.WriteLine("What is your favorite number?");
            //int favoriteNumber = Console.ReadLine();

                // This code above won't work because Console.ReadLine()
                // can only take in string data types, but we are assigning 
                // the value to an integer. To make this work, we'll have to 
                // utilize "casting" which is the practice of changing a piece
                // of data from one data type to another data type. This is common
                // with user input like the above code where most user input is 
                // going to be a string and sometimes you want to convert that
                // to a number or a boolean, etc. To "cast" this, we are first going
                // change the 'int' to 'string' data type.

            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42; 
                // 'byte' represents a whole number between 0 and 255.
            sbyte currentTemperature = -23; 
                // 'sbyte' represents a whole number between -128 and 127.
            char questionMark = '\u2103'; 
                // Unicode in C# is denoted with sing quotation marks.

            //Console.WriteLine(questionMark);
            //Console.ReadLine();

            decimal moneyInBank = 100.5m;
                // 'm' doesn't mean "million," it's a required suffix character for 
                // decimal data types to help the compiler differentiate it from other
                // similar types. 

                // 'decimal' is really only used for financial transactions. It was
                // actually built for that, because it's the largest of the data types
                // that can take decimal points. For example, when you're moving money 
                // around a lot, you don't want anything to get lost because of rounding.

            double heightInCentimeters = 211.1039478329;
                //'double' represents any number up to 15 or 16 digits in length.
            
            float secondsLeft = 2.62f;
            // 'f' is another required suffix character to help the compiler
            // differentiate this as a 'float' instead of a 'decimal' data type.

            short temperatureOnMars = -341;
            // 'short' represents a whole number between -32,678 and 32,767
            // and it is the 16-bit version of 'int.'

            string myName = "Shay";

            // Next, we'll so some more "casting" but this time we will
            // convert an integer to a string, which is much easier than
            // string to integer.
            int currentAge = 30;
            string yearsOld = currentAge.ToString();


            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

            //'Casting' is actually a risky operation in programming, so 
            // it's usually best to avoid it whenever possible, unless there
            // is no way around it. If you find yourself having to 'cast' 
            // variables frequently, it's often a sign of a poorly designed
            // program. Time to redesign!

        }
    }
}
