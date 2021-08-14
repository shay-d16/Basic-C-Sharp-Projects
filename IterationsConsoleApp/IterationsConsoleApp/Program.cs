using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What city and state do you live in?");
        string cityState = Console.ReadLine();
        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());
       

        string[] questions = new string[3];
        questions[0] = "Your name is " + name + ",";
        questions[1] = "You live in " + cityState + ",";
        questions[2] = "And you are " + age + " years old.";
        // The strings in this array will include the user input values.

        foreach (string question in questions)
        {
            Console.WriteLine(question);
        }
        // Here, I created a foreach loop that would iterate through each
        // string in the array, and appending the string by adding the user
        // input to it.

        while (age > 19 && age < 30)
        {
            Console.WriteLine("Wow, you're in your twenties! Oh, to be young!");
            break;
        }


        Console.WriteLine("\nHow old is your best friend?");
        int friendsAge = Convert.ToInt32(Console.ReadLine());

        if (age > friendsAge)
        {
            Console.WriteLine("So you are older than your best friend!");
        }
        else if (age < friendsAge)
        {
            Console.WriteLine("So you are younger than your best friend!");
        }
        else if (age == friendsAge)
        {
            Console.WriteLine("Oh wow! You and your best friend are the same age!");
        }
          

        
        
        
        Console.ReadLine();
    }
}

