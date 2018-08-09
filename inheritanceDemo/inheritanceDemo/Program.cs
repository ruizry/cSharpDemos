using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> newEmployee = new Employee<string>("Sample", "Student", new List<string> { "test1", "test2", "test3" });

            newEmployee.SayName();

            Console.WriteLine("\nInterface Demo------------------");
            Console.WriteLine("\nCalling method Quit inherited from IQuittable");
            newEmployee.Quit();

            Console.WriteLine("\nOverloading Demo----------------");
            Console.WriteLine("\nCreating three new employees to test overloaded == operator");

            Employee<int> testEmployee1 = new Employee<int>("Roger", "Frank", new List<int> { 1, 2, 3, 4 }, 777);
            Employee<int> testEmployee2 = new Employee<int>("Jimmy", "Lee", new List<int> { 1, 2, 3, 4 });
            Employee<int> testEmployee3 = new Employee<int>("Jimmy", "Lee", new List<int> { 1, 2, 3, 4 });

            Console.WriteLine("The following employees were added");
            testEmployee1.SayName();
            testEmployee2.SayName();
            testEmployee3.SayName();

            Console.WriteLine();

            if (testEmployee1 == testEmployee2)
                Console.WriteLine("testEmployee1: " + testEmployee1.FirstName + " with id: " + testEmployee1.Id + " is the same as " + "testEmployee2: " + testEmployee2.FirstName + " with id: " + testEmployee2.Id);
            else
                Console.WriteLine("testEmployee1: " + testEmployee1.FirstName + " with id: " + testEmployee1.Id + " is not the same as " + "testEmployee2: " + testEmployee2.FirstName + " with id: " + testEmployee2.Id);

            if (testEmployee2 == testEmployee3)
                Console.WriteLine("testEmployee2: " + testEmployee2.FirstName + " with id: " + testEmployee2.Id + " is the same as " + "testEmployee3: " + testEmployee3.FirstName + " with id: " + testEmployee3.Id);
            else
                Console.WriteLine("testEmployee2: " + testEmployee2.FirstName + " with id: " + testEmployee2.Id + " is not the same as " + "testEmployee3: " + testEmployee3.FirstName + " with id: " + testEmployee3.Id);

            Console.WriteLine("\nGenerics Demo-------------------");

            Console.WriteLine("\nCreating employee object with string list");
            Employee<string> genEmployee1 = new Employee<string>("Sample", "Student", new List<string> { "test1", "test2", "test3" });
            Console.WriteLine("Printing all contents of things list within new object");
            foreach (string thing in genEmployee1.things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nCreating another employee object with int list");
            Employee<int> genEmployee2 = new Employee<int>("Sample", "Student", new List<int> { 354, 5, 9038 });
            Console.WriteLine("Printing all contents of things list within new object");
            foreach (int thing in genEmployee2.things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
