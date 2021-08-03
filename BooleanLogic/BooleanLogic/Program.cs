using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            //AND OPERATOR
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //OR OPERATOR
            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //EQUALS OPERATOR
            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //DOES NOT EQUAL OPERATOR
            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //XOR OPERATOR
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);
            // The XOR operator will evaluate to 'True' if one of the values is true,
            // but not both.

            Console.ReadLine();
        }
    }
}
