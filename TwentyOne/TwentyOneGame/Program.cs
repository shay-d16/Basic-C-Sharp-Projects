using System;
using System.IO;
//using System.IO;
//using TwentyOne.BaseClasses
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------- FILE IO ----------------------------------------------------
            // In this section, we will discuss how to write and read text to and from a text file. One of the most
            // common uses of writing or reading anything from a text file would be "logging", which is when you
            // put in a meaningful entry into a file or database based on an action of the program. Some programs 
            // will log every method call if they really want to track everything, others will log just the errors.
            // Right now, we're going to add logging on every card dealt to a text file.
            // The 'File' class exists in the 'System.IO' namespace.

            //string text = "Here is some text";
            //File.WriteAllText(@"C:\Users\USER\OneDrive\Desktop\Logs\log.txt", text);
            // 'File.WriteAllText()' takes in an argument of the path of the file and the 'text' you want written in
            // it. The '@' symbol just means to read this string exactly as it is, otherwise you would have to add
            // double backslashes, one of which is an escape character.

            //string text = File.ReadAllText(@"C:\Users\USER\OneDrive\Desktop\Logs\log.txt");
            // Now when you run the program an hover over 'text' you'll see the "Here is some text." from the text file.

            //-------------------------------------------- DATETIME ---------------------------------------------------
            // A 'DateTime' is a value type, as well as a struct, meaning it's not nullable. 
            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
            // When you run the code to this point and hover over 'ageAtGraduation', you'll find '{6584.08:01:37}' in 
            // {days.hours.milliseconds.minutes}. 'TimeSpan' is just an easy way to compare two dates.

            //------------------------------------ ASSEMBLIES AND NAMESPACES -------------------------------------------
            // ASSEMBLY: In the .Net Framework, anything that you write in code is essentially compiled twice. All the 
            // code written below will be compiled by the C# compiler into Intermediate Language. That file is typically
            // going to be .exe or .dll; if it's a library file, it will be .dll; if it's meant to just be executed, it
            // will be a .exe. That .exe or .dll is in essence an assembly, and then it is compiled again but this time 
            // into whatever specific machine code is being used by that computer. An assembly is essentially what you 
            // get after you compile your C# code into intermediate language. So the 'TwentyOne' project is going to
            // compile into a .exe

            // NAMESPACE: A namespace is a way of organizing your code. Let's say you're working for a big online retailer
            // like Amazon or Walmart for example, you could only have one class named "Product" or "Sell" or "Chair", 
            // but with namespaces you're able to divide your code so that you can have multiple "Chair" classes and you 
            // would be able to differentiate each of them based on it's namespace.

            // Look to the 'Game' class for second example.

            // 'USING' STATEMENT: The 'Console' part of 'Console.WriteLine();' belongs to the 'System' namespace. If we  
            // were to delete 'using System;', red squigglies would appear under all code using the 'Console' class in 
            // the program. However, you don't neccesarily need to have 'using Systems;' written above. You could type out 
            // the full path like 'System.Console.WriteLine()'.

            // 'USING' AND SUB-NAMESPACES: When get to build large applications, you'll definitely want to use namespaces 
            // and subnamespaces. For example, our 'IWalkAway' interface could potentially be under a namespace called 
            // 'TwentyOne.Interfaces' and we would have a whole section of interfaces. Then any class that uses this 
            // namespace would need a 'using TwentyOne.Interfaces' above their namespace so the program recognizes it.
            // If you wanted to create another interface called 'IWalkAway' it would have to be in a difference namespace.
            // That way you are able to reuse these, and things don't get confused. Sometimes, you have two classes which
            // have the same name, but they exist in different namespaces, yet you're using the name space at the top
            // (i.e. 'using TwentyOne.Interfaces'). Remember, the 'using' statement makes it so that you don't have to 
            // type out the full path, i.e. 'System.Console.WriteLine()', every time you called that class from that
            // specific namespace.

            // ------------------------------------------- CLASS LIBRARIES ---------------------------------------------
            // Now, we'll focus on creating class libraries as well as how we can add references to assemblies. In the 
            // Solution Explorer window, you'll notice a "References" tab in the 'TwentyOne' project, and we're going to
            // talk about how we can add code there so that this 'TwentyOne' project can reference third-party libraries.
            // In terms of this program we've built of a game of 21, where we have some generic classes and inheritance
            // happening, it is practically a library in itself. Theoretically, we could take all of ou code, except for 
            // 'Program' class, and we could bundle it up and make it an open-source, third-party library that someone 
            // could use methods from to conduct a game of 21. Their implementation in the 'Main()' method would be 
            // different, but everything else would be the same. 

            // So, we're going to take all of this code and turn it into a library. Right click on your 'Solution', choose
            // "Add", click "New Project", and then you will choose "Class Library (.Net Framework)". We're going to call
            // this library 'Casino'. In the 'Casino' library is a 'Class1' class, which looks almost exactly like a console 
            // application. The only difference is that its 'Class1' does not have a 'Program' class and 'Main()' method. 
            // It's just a collection of classes. We can delete this 'Class1' class since we won't need it for this example.
            // Next, we will move each class from the 'TwentyOne' project to the 'Casino' library, except for the 'Program'  
            // class. Then delete each of the moved classes from the 'TwentyOne' project.

            // Now that each file has been successfully moved, we have to go into the 'Card', 'Dealer', 'Deck', 'Game', and 
            // 'Player' classes and change the namespace from 'TwentyOne' to 'Casino'. Change the 'IWalkAway' namespace to
            // 'Casino.Interfaces'.

            // Anything that deals with 'TwentyOne'('TwentyOneDealer', 'TwentyOneGame', and 'TwentyOneRules') will be put  
            // into the 'TwentyOne' subsection of 'Casino', with the namespace written like 'Casino.TwentyOne'.

            // If we're going to access the class files in the 'Casino' library, we'll have to use references. First, we
            // have to build the actual .dll library file: Right-click on 'Casino' in the solution explorer and select
            // "Build". When the Build has succeeded, right-click on the "References" tab in the 'TwentyOne' project and
            // choose "Add Reference", then choose "Browse" and find the repository folder containing the 'TwentyOne' 
            // project, select the "Casino" folder > "bin" > "Debug" and there should be a "Casino.dll" file which
            // you will select and hit "Add" and finally "Okay". Now you should find the file in the project's
            // "References" tab.            
            // You can now add 'using' statements above 'using.Casino' and 'using .TwentyOne' to the top.

            // After testing to see that this console application still works properly, we can now say that we created
            // a library file, and this is a file that not only we can reference in our application, but others could 
            // too. You could upload it onto a GitHub or Microsoft Third Party packages library, and someone could 
            // download it into that program and use it.

            // ACCESSABILITY MODIFIERS: Accesibility modifiers control which part of your code is exposed.
            // 'public' and 'private' are both accessability modifiers. 'Public' means it's 
            //  accessible anywhere. For example: the 'Dealer' class is 'public', so once the 'TwentyOne' application
            // has imported the 'Casino' library, it will have access to the 'Dealer' class. However, if the class was
            // 'private' 'TwentyOne' wouldn't have access to this class, b/c anything with a 'private' modifier is only
            // accessible within it's class.
            // There are more modifiers like 'protected', meaning it's limited to the class it's created in, as well as
            // any classes that derive from it. 'Internal', meaning these methods can only be accessed to methods of the
            // same assembly. If you were to make the 'Dealer' class 'internal', then only the classes in the 'Casino' 
            // assembly can access it, and that would be a problem if you ever tried to access it directly from 
            // the 'TwentyOne' application.
            // It's good practice to declare the accessibility of a class, b/c it's a way of controlling your code.
            // Note: Every time you update a library file, you will have to "Rebuild" the library, or use CTRL+Shift+B.

            //---------------------------------------- ADDITIONAL C# FEATURES ------------------------------------------
            // CONSTRUCTOR CALL CHAIN: The idea behind a constructor call chain is that you can define multiple 
            // constructors and basically utilize an earlier constructor. It helps in preventing writing things
            // more than once. 

            // Look to the 'Player' class for an example.

            //Player newPlayer = new Player("Shay");
            // Now, when you run the code to this point, and hover over 'newPlayer' you will see a 'player' named "Shay"
            // with a balance of 100. This is how you chain constructors. It is much more useful when you are dealing with 
            // a lot of constructors or very long ones.

            // IMPLICITLY DEFINED VARIABLES: Remember, C# is a typed language, meaning the data type of an object MUST be 
            // declared before you declare the variable. However, C# now offers an exception to this. You can implicitly
            // define a variable by using the keyword 'var':
            //var newPlayer = new Player("Shay");
            // This will be the most useful you don't want to have to type out something like:
            //'Dictionary<string, string> newDictionary = new Dictionary<string>'
            // You could shorten it to 'var newDictionary = new Dictionary<string, string>();
            // The general rule of thub when it comes to the 'var' keyword is: if ever the data type is in question 
            // then you would want to declare the data type for readability purposes. You can tell that the above code
            // has a Dictionary data type, but sometimes data types can be obscured in a lambda espression or there's
            // a method that you aren't familiar with. Using 'var' too often can make things confusing. You would only
            // use it sometimes if you wanted to type things up quickly or didn't want to type out a long data type.

            // CONSTANTS: You can declare constants in C#. Once a program has been compiled, any constants created 
            // cannot be changed. This is another aspect of C# where you can assert control over your program.
            const string casinoName = "Grand Hotel and Casino";
            // In this example, this constant isn't going to make a huge difference in our code. However, if we 
            // referenced it several times in this program, then it would be useful to have that 'const' keyword. You
            // wouldn't have to worry that some user input, for example, or someone else using the code would change
            // that name. While this program is running, that name will not change.

            // GUID: There is a class in C# that enables you to make a global unique identifier and it's called a GUID.
            // If you have a user in your program, you could access their GUID and then look that up in a table to find out
            // their name, for instance.The advantage of a GUID is that b/c of the way it's built the odds of getting a 
            // dupilcate GUID are slim to none; you could create as many GUIDs or users as you want in your database and 
            // never worry that you're going to have a non-unique identifier for that user.
            //Guid identifier = Guid.NewGuid();
            // Let's create a GUID once the 'player' gives their name. To do this we will add a GUID property to the
            // 'Player' class.
            // One option for GUIDs is that you can pass in a string which would give a GUID structure by using the value 
            // represented by the string. You can basically pass in values and the algorithm.

            //------------------------------------------- EXCEPTION HANDLING --------------------------------------------
            // An exception is an event which occurs during the excution of a program that disrupts the normal flow of the 
            // programs instructions. Any time you've seen an "Exception Unhandled" window pop up has all been in the 
            // "Debugging Mode". By default Visual Studio is in "Debugging Mode" any time you run an application from 
            // inside of it. That is different than how an application would run outside of Visual Studio, as a stand-alone
            // .exe file.
            // If you were to choose the "Start Without Debugging" option, and the program ran into an error, the error 
            // message would show up in the console itself and a window would pop up saying "TwentyOne has stopped working/
            // Hang on while Windows reports the problem to Microsoft...". The user not only saw a raw, ugly error message,
            // but program iteself crashed. Exception handling is the process of preventing this.

            // Look below for first example.

            // Another check we need to make is for when the user places their bet, b/c they could easily enter "-100",
            // then if they busted, instead of losing 100, they user ends up gaining 100, which is a problem. Look to 
            // 'TwentyOneGame' class under 'bet'.
            // It's best practice to be as specific as possible when catching exceptions, that way they can be handled
            // appropriately. C# has a way to create your own exceptions, which is how we'll deal with the above issue in 
            // the user attempts to cheat. Right-click 'Casino' and add a class called 'FraudException'. We will have this 
            // class inherit from the built-in 'Exception' class. If you'll notice, the more specific exceptions that
            // are built into the framework all inherit from this 'Exception' class. Look to 'FraudException' class.

            //--------------------------------------------- DATA ACCESS -------------------------------------------------
            // Look to 'Data_Access_in_Visual_Stuido.txt' for more notes about Database Access.

            // In the two 'catch' blocks below, we are going to put some code for logging those exceptions to the
            // 'TwentyOneGame' database. Rather than create a new class, we'll instead create a private method below this
            // 'Main()' method called 'UpdateDbWithException', pass in an 'Exception' object so we can do something 
            // with that object.
            // We are making this method 'private' since it will only be used in this class. And we'll make it 'static' 
            // so we don't have to create a new instance of 'Program'. This will be a 'void' method, meaning it won't
            // return anything. Normally, you would want to return something to the database, like 'true' or 'false', but  
            // for simplicity we will keep this method 'void'.
            // It is in this class that we will be dealing with ADO.NET, a part of the 'System' library which deals with 
            // database connections.

            // The first thing that we want to happen in this program is to print a welcome message to the user.
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            // user inputs their name and it is stored in the variable 'playerName'.

            // EXCEPTION HANDLING: Any time you have to convert to an integer and you're relying on user input, checks like this
            // are necessary :
            bool validAnswer = false; //We'll set it at 'false' initially
            int bank = 0;
            while (!validAnswer) //This loop will get hit no matter what b/c we set it to 'false' from the beginning.
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                // This 'TryParse()' method is similar to 'Convert.ToInt32()' in that it casts the object from string
                // to int. The difference is that 'TryParse()' has a 'return' value which indicates whether or not the 
                // conversion succeeded. If it does, it gets sent back to it's 'out' parameter, the 'bank' variable.
                // If not, then 'bank' remains 0.
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }//We'll have to do this same thing in the 'TwentyOneGame' class when placing bets

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            // Here, we used string formatting where we put a variable placeholder in curly braces (think "wildcard"),
            // with 'playerName' being the variable to take it's place. 
            string answer = Console.ReadLine().ToLower();
            // converting the 'answer' given by the user to lower case using 'ToLower()' makes it easier to check
            // against.
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                // If the user wants to play, let's create a 'Player' object, and let's initiate the object with the
                // user's name and how much money they brought.
                Player player = new Player(playerName, bank);
                // *Remember that the 'Player' object takes in two parameters.

                player.Id = Guid.NewGuid();
                //When the 'player' joins a game, let's log the player's GUID as soon as they start the game:
                using (StreamWriter file = new StreamWriter(@"C:\Users\USER\OneDrive\Desktop\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);                    
                }//Now, when you run the program, it will log the player's GUID along with their hand and time stamp.

                Game game = new TwentyOneGame();
                // polymorphism at work here. We do this to expoze the overloaded operators in the 'TwentyOneGame' 
                // class, which inherits from the 'Game' class.
                game += player; 
                // This adds the 'player' to the 'game'.
                player.isActivelyPlaying = true; 
                // 'isActivelyPlaying' is a bool property in the 'Player' class that we can use in a while loop which
                // will state that while the player 'isActivelyPlaying' play the game.
                while (player.isActivelyPlaying && player.Balance > 0)
                    //This loop checks that the player wants to play AND they have enough money to play. 
                    //If both conditions are met, this loop will continue to run.
                {
                    try
                    {
                        game.Play();
                        // 'game.Play()' is going to to play one 'Hand', and this while loop is going to loop through 
                        // again and again as long as the player 'isActivelyPlaying' and their 'Balance' is greater than 0. 
                    }
                    catch (FraudException) //the more specific exceptions should be placed above the general exceptions.
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return; //ends the program
                    }
                    catch (Exception) //for generic exceptions.
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        Console.ReadLine();
                        return; 
                    }

                }
                // If the user exits the while loop, we'll want to subtract them from the game.
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            // If the user didn't answer "yes" this message will print:
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            // This saves us from having to write an else statement when we don't need it which makes the code cleaner.
            // If the user answers "no" it will skip the 'if' statement and jump straight to end, here:
            Console.Read();
            // This is the entirity of the 'Main()' method. Everything else that happens in this game is going to happen
            // "below the surface", which is what we want because we don't want too much going on in the 'Main()' method.
        }
        
        private static void UpdateDbWithException(Exception ex) //takes in an argument of type 'Exception' called 'ex'
        {
            // DATA ACCESS: The first thing we need in this method is a "connection string" which is a long string that 
            // typically contains information about the database instance you're trying to connect to (i.e. a username
            // and password location and how to access it). You always need a connection string to connect to a database.
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";




        }
    }
}   
