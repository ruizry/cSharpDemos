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
            Employee newEmployee = new Employee();

            newEmployee.FirstName = "Sample";
            newEmployee.LastName = "Student";

            newEmployee.SayName();

            Console.WriteLine("\nCalling method Quit inherited from IQuittable");
            newEmployee.Quit();

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
