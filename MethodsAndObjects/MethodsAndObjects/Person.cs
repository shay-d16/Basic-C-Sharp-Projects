using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        //Give the 'Person' class two string properties.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Void method prints the full name to the console.
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
