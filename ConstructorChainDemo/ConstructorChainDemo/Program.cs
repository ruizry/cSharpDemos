using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainDemo
{
    class Program
    {
        const int BRANCH1ID = 5555;
        const string BRANCH1NAME = "Grassland";

        static void Main(string[] args)
        {
            var location1 = new Dictionary<int, string> { { BRANCH1ID, BRANCH1NAME } };

            Console.WriteLine("Enter a name for an employee");
            string name = Console.ReadLine();
            Console.WriteLine("Enter an hourly rate for this employee");
            double rate = Convert.ToDouble(Console.ReadLine());

            Employee emp1 = new Employee(name, location1, rate);
            Console.WriteLine("Employee created\nName: " + emp1.Name + "    Location: " + emp1.Location.Values.ElementAt(0) + "    Rate: " + emp1.Rate);

            Console.WriteLine("\nNow creating new employee using a different constructor");
            Console.WriteLine("\nEnter a name for an employee");
            name = Console.ReadLine();
            Employee emp2 = new Employee(name, location1, 20.00);
            Console.WriteLine("Employee created\nName: " + emp2.Name + "    Location: " + emp2.Location.Values.ElementAt(0) + "    Rate: " + emp2.Rate);

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string Name;
        public double Rate;
        public Dictionary<int, string> Location;

        public Employee(string n, Dictionary<int, string> l, double r)
        {
            Name = n;
            Rate = r;
            Location = l;
        }

        public Employee(string n, Dictionary<int, string> l) : this(n, l, 15.00) { }

    }
}
