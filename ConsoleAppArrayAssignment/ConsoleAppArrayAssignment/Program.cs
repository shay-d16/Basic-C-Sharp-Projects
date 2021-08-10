using System;
using System.Collections.Generic;


namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[4];
            stringArray[0] = "This string has an index of 0";
            stringArray[1] = "This string has an index of 1";
            stringArray[2] = "This string has an index of 2";
            stringArray[3] = "This string has an index of 3";

            Console.WriteLine("Select an index number from 0-3 to display a string");
            int selectIndex = Convert.ToInt32(Console.ReadLine());
                if (true)
                {
                    Console.WriteLine(stringArray[selectIndex]);
                }
                else
                {
                    Console.WriteLine("Sorry that index does not exist in this instance");

                }
            

            int[] numArray = { 5, 6, 7, 8, 9 };
            Console.WriteLine("\nSelect an index number from 0-4 to display an integer from an array");
            int selectNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numArray[selectNum]);

            Console.ReadLine();


        }
    }
}
