using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        //LISTS
        //// Notice above the 'using System.Collections.Generic'; This is a 
        //// namespace thats a part of the Framework Class Library that we're
        //// going to use to create a list. Lists are similar to array, but the
        //// difference is in the 'Generics' part of that statement. Lists can
        //// be created with ANY data type.

        List<string> intList = new List<string>();
        //// Notice you don't have to declare a length to this list
        intList.Add("Hello");
        intList.Add("Shay");
        intList.Remove("Shay");


        Console.WriteLine(intList[0]);
        Console.ReadLine();

        //BYTE ARRAY
        //// Sometimes you will have to store images into a database by using binary
        //// information. The way to get an image into a database table through C# is
        //// actually through a 'byte array' and from there you can perform a C# action 
        //// to store the item into the database.
        byte[] byteArray = new byte[5000];

        // ARRAYS
        //// An array in C# is very similar to an array in JavaScript, 
        //// where a group values that you can perform methods and functions on
        //// is contained within square brackets. The difference is that in C#,
        //// you not only have to declare an array with square brackets, but you 
        //// but you also have to give the type of variable 

        //// To actually create an array, you first have to instantiate it
        //// because arrays are a C# construct called an 'object.' So you'll have 
        //// have to create a 'new' object of the array.

        //int[] numArray = new int[5];
        //// At first, the brackets in 'new int[]' have a red
        //// squiggly line and that's because Array creation must have an
        //// an array size or array initializer. You have to say how many
        //// variables this array holds.

        //// To add items to this array, you'd say:
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000};
        //// This is a shorter way to the exact same thing as the previous array
        //// You can change the values in the array, but once you initialize it,
        //// the length of th is set.

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //// In this code, you can see that C# has an even simpler way to write out
        //// a new integer array without having to actually say it's a new array.
        //// This is the easiest way to initialize an array in C#.

        //// You can target exact items in the array to change them, but you are limited 
        //// to the size of the array once it has been initialized
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
        }
    }
