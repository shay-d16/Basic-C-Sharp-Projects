using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        //ABSTRACT CLASSES ASSIGNMENT:
        //1. Create an abstract class called Person with two properties: string firstName and string lastName.
        //2. Give it the method SayName().
        //3. Create another class called Employee and have it inherit from the Person class.
        //4. Implement the SayName() method inside of the Employee class.
        //5. Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName
        //   “Student”. Call the SayName() method on the object.

        //POLYMORPHISM ASSIGNMENT:
        //1. Create an interface called IQuittable and have it define a void method called Quit().
        //2. Have your Employee class from the previous drill inherit that interface and implement
        //   the Quit() method in any way you choose.
        //3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
        //   Hint: an object can be of an interface type if it implements that specific interface.
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName="Sample", lastName="Student" };
            employee.SayName();

            IQuittable quittable = new Employee();           
            quittable.Quit();
            //Using polymorphism, I created a 'quittable' object and called the 'Quit()' method on it

            Console.ReadLine();
        }
    }
}
