using System;

namespace PolyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Polymorphism Demo");

            Console.WriteLine("\nCreating instance of Employee class. Employee inherits from the Person class");
            Employee emp1 = new Employee("Sample", "Employee");

            Console.WriteLine("\nPrinting employee information using SayName method from Person class");
            emp1.SayName();

            Console.WriteLine("\nThis is the end of program, press enter to exit");
            Console.ReadLine();
        }
    }
}
