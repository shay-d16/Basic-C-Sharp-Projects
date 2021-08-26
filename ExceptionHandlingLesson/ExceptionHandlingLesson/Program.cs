using System;




class Program
{
    static void Main(string[] args)
    {
        try
        {


            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Divinding the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals" + numberThree);
            Console.ReadLine();
        }
        catch(FormatException ex)//Here we are only catching a FormatException and assigning it the vairable 'ex'.
        {
            Console.WriteLine(ex.Message); //This is the message of the error.
            return;
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");//You can use a custom message like this, otherwise 'ex' will just display the default error message
        }
        catch(Exception ex)//This is a "general" exception, basically for any other type of unforseen error.
        {
            Console.WriteLine(ex.Message);
        }
        finally //If the 'try' executes perfectly, with no exceptions, 'finally' will still run.
        {       //It will still run even if there is an exception.
                //The reason we use 'finally' at all is because when the program catches an exception
                //often times it will stop execution. For example, you usually want to log errors into 
                //the database, and sometimes when you have an error you want to also have something else
                //exectute (i.e. take the user to an error page), in which case you would use 'return'.
                //'return' is pretty common when using a try/catch block
            Console.ReadLine();
            //Putting Console.ReadLine(); inside the 'finally' block guaruntees that the program will call 
            //this line of code. Without the 'finally' the program would stop executing at 'return.'
            //Often times, your 'finally' block will have a database log, which is logging if something occurs
            //or an exception is caught. An example of this would be if this was a method to charge a credit card.
            //You would want to log when a card was charged regardless of whether it went through or an exception 
            //was caught.
        }
        //Exception handling is something you are going to use often, especially when debugging.
        //If you're trying to find out whats wrong with your program, it is sometimes helpful to 
        //throw that code inside of a catch block so that you can catch and view that exact error
        //message.
    }
}

