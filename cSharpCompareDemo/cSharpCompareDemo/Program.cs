using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpCompareDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            double firstRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int firstHours = Convert.ToInt32(Console.ReadLine());
            double firstResult = firstRate * firstHours;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            double secondRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int secondHours = Convert.ToInt32(Console.ReadLine());
            double secondResult = secondRate * secondHours;
            Console.WriteLine("Weekly salary of Person 1:\n" + firstResult);
            Console.WriteLine("Weekly salary of Person 2:\n" + secondResult);
            bool compareSal = firstResult > secondResult;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + compareSal);
            Console.ReadLine();
        }
    }
}
