using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBranchingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50.0)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                double length = Convert.ToDouble(Console.ReadLine());
                double dimensions = width * height * length;
                if (dimensions > 50.0)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double rate = dimensions * weight / 100.00;
                    rate = Math.Round(rate, 2);
                    string result = rate.ToString("0.00");
                    Console.WriteLine("Your estimated total for shipping this package is: $" + result + "\nThank you.");
                    Console.ReadLine();
                }
            }
        }
    }
}
