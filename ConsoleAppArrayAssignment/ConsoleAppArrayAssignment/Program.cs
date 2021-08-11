using System;
using System.Collections.Generic;


namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[4]; 
            //To create an array you first have to create an instance of the array object
            stringArray[0] = "This string has an index of 0";
            stringArray[1] = "This string has an index of 1";
            stringArray[2] = "This string has an index of 2";
            stringArray[3] = "This string has an index of 3";

            Console.WriteLine("Select an index number from 0-3 to display a string");
            // This try/catch block will ensure that if the user inputs an index number
            // that isn't part of the array will be met with an exception message
                try
                 {
                    int selectIndex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(stringArray[selectIndex]);
                 }
                catch
                {
                    Console.WriteLine("Sorry that index does not exist in this instance");
                }
            

            int[] numArray = { 5, 6, 7, 8, 9 }; //The curly brackets are a simple way to initialize this array.
            Console.WriteLine("\nSelect an index number from 0-4 to display an integer from an array");
            int selectNum = Convert.ToInt32(Console.ReadLine());
            //This converts the user input from a string to an integer
            
            try
            {
                Console.WriteLine(numArray[selectNum]);
            }
            catch
            {
                Console.WriteLine("Sorry that index does not exist in this array");
            }

            List<string> stringList = new List<string>();
            stringList.Add("This is index 0 of my string list");
            stringList.Add("This is index 1 of my string list");
            stringList.Add("This is index 2 of my string list");
            stringList.Add("This is index 3 of my string list");
            stringList.Add("This is index 4 of my string list");
            
            Console.WriteLine("\nNow, select an index from 0-4 of a list of strings");
            int selectList = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(stringList[selectList]);
            }
            catch
            {
                Console.WriteLine("That index does not exist in this list.");
            }
           
            Console.ReadLine();

        }
    }
}
