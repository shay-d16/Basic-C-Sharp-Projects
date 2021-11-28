using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    // CONSTRUCTOR ASSIGNMENT REQUIREMENTS:
    //1. Create a const variable.
    //2. Create a variable using the keyword “var.”
    //3. Chain two constructors together.
    public class Student
    {
        private string Name;
        private int Age;
        public Student(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine("Student name: " + Name);
        }
        public Student(string Name) : this(Name, 26)
        {
            Console.WriteLine("Age: " + Age);
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
                const string studentCreator = "Shay Rossiter";

                var student = new Student(studentCreator);
                
                Console.ReadLine();

        }
    }
}
