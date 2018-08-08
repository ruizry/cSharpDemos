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
            Employee newEmployee = new Employee("Sample", "Student");

            newEmployee.SayName();

            Console.WriteLine("\nCalling method Quit inherited from IQuittable");
            newEmployee.Quit();

            Console.WriteLine("\nCreating three new employees to test overloaded == operator");

            Employee testEmployee1 = new Employee("Roger", "Frank", 777);
            Employee testEmployee2 = new Employee("Jimmy", "Lee");
            Employee testEmployee3 = new Employee("Jimmy", "Lee");

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

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
