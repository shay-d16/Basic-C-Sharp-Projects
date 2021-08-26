using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // USER INPUT QUESTIONS
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What city and state do you live in?");
        string cityState = Console.ReadLine();
        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());
       
        // STRING ARRAY
        string[] questions = new string[3];
        questions[0] = "Your name is " + name + ",";
        questions[1] = "You live in " + cityState + ",";
        questions[2] = "And you are " + age + " years old.";
        // The strings in this array will include the user input values.

        // FOREACH LOOP
        foreach (string question in questions)
        {
            Console.WriteLine(question);
        }
        // Here, I created a foreach loop that would iterate through each
        // string in the array, and appending the string by adding the user
        // input to it.

        // WHILE LOOP
        while (age > 19 && age < 30) 
        {   //While the users age is greater than 19 AND less than 30, print this:
            Console.WriteLine("Wow, you're in your twenties! Oh, to be young!");
            break;
        }   
        while (age > 29 && age <= 39 )
        {   //While the users age is less than 29 AND less than or equal to 39, print this:
            Console.WriteLine("You're in your thirties!");
            break;
        }

        //IF ELSE STATEMENTS
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


        List<string> friendsList = new List<string>();
        friendsList.Add("Helayna");
        friendsList.Add("Jill");
        friendsList.Add("Brooke");
        friendsList.Add("Jett");
        friendsList.Add("Scott");

        Console.WriteLine("\nNow, type in some text to search my list of friends and the index of each item in the list:");
        string searchList = Console.ReadLine();

        if (friendsList.Contains(searchList)) //If friendsList contains text from the user input of searchList:
        {
            foreach (string item in friendsList) //set the variable for items in this list 
            {
                if (item == searchList) //Compare to see if the item is equal to user input
                {
                    Console.WriteLine(friendsList.IndexOf(searchList));//If true, display the index of the item that matches the user input.
                }
            }
        }
        else //If the user input doesn't match any items in the list, display this message:
        {
            Console.WriteLine("List does not contain this item.");
        }


        Console.WriteLine("\nAnd now, I have a list containing the names of my siblings. \nTheir names are Malik, Kaylani, Jordan, and Skyla. \nType in a name to see which of these appears twice in the list:");
        string searchSibs = Console.ReadLine();


        List<string> siblingsList = new List<string> {"Malik", "Kaylani", "Jordan", "Skyla", "Jordan" };

        if(siblingsList.Contains(searchSibs))
        {
            for (int i = 0; siblingsList.Count > i; i++) //Use a for loop to iterate through the list
            {
                if (siblingsList[i] == searchSibs)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("List does not conatin this item.");
        }

        Console.WriteLine("Lastly, I've created a list of cities I have lived in: ");
        
   

        List<string> citiesList = new List<string> { "Riverside,CA", "San Diego, CA", "Los Angeles, CA", "Lake Elsinore, CA", "Lakeland, FL", "San Diego, CA", "Federal Way, WA" };
        List<string> duplicates = new List<string>();
        
            foreach(string c in citiesList)
            {
                if(duplicates.Contains(c))
                {
                    Console.WriteLine("This has already been repeated " + c);
                }
                else
                {
                    Console.WriteLine(c + " has not been repeated");
                }
                duplicates.Add(c);                               
            }

        
        
       
        

        Console.ReadLine();
    }
}

