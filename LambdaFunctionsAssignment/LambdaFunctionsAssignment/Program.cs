using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionsAssignment
{
    class Program
    {
        // ASSIGNMENT REQUIREMENTS:
        // 1. In the Main() method, create a list of at least 10 employees. Each employee should have a first and last
        //    name, as well as an Id. At least two employees should have the first name “Joe”.
        // 2. Using a foreach loop, create a new list of all employees with the first name “Joe”.
        // 3. Perform the same action again, but this time with a lambda expression.
        // 4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

        static void Main(string[] args)
        {
            Employee employee = new Employee();

            List<Employee> currentEmployees = new List<Employee>();

            currentEmployees.Add(new Employee() { firstName = "Joe", lastName = "Evans", ID = 1  });
            currentEmployees.Add(new Employee() { firstName = "Sherry", lastName = "Wilson", ID = 2  });
            currentEmployees.Add(new Employee() { firstName = "Jack", lastName = "Peterson", ID = 3 });
            currentEmployees.Add(new Employee() { firstName = "Billy", lastName = "Bob", ID = 4 });
            currentEmployees.Add(new Employee() { firstName = "Andy", lastName = "Davis", ID = 5 });
            currentEmployees.Add(new Employee() { firstName = "Maxine", lastName = "Lowe", ID = 6 });
            currentEmployees.Add(new Employee() { firstName = "Jessica", lastName = "Stevens", ID = 7 });
            currentEmployees.Add(new Employee() { firstName = "Joe", lastName = "Smith", ID = 8 });
            currentEmployees.Add(new Employee() { firstName = "Ariana", lastName = "Gonzales", ID = 9 });
            currentEmployees.Add(new Employee() { firstName = "Dawn", lastName = "Jackson", ID = 10 });

            //Console.WriteLine("Employees with the first name \"Joe\":");
            //List<Employee> newList = new List<Employee>();

            //foreach(Employee e in currentEmployees)
            //{
            //    if (e.firstName == "Joe")
            //    {
            //        newList.Add(e);
            //        Console.WriteLine(e.firstName + " " + e.lastName);
            //    }                
            //}           

            Console.WriteLine("Employees with the first name \"Joe\":");
            List<Employee> newList = currentEmployees.Where(x => x.firstName == "Joe").ToList(); 
            foreach (Employee e in newList)
            {                
                Console.WriteLine(e.firstName + " " + e.lastName);
            }

            Console.WriteLine("\nEmployees with an ID number greater than 5:");
            List<Employee> idList = currentEmployees.Where(x => x.ID > 5).ToList();
            foreach (Employee e in idList)
            {                
                Console.WriteLine(e.firstName + " " + e.lastName + " " + e.ID);
            }

            Console.ReadLine();
        }
    }
}
