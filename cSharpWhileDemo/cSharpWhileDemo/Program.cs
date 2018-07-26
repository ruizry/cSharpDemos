using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be mulitplied by 4 5 times:");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            bool repeat = true;
            string choice = "true";
            while (i <= 5)
            {
                number *= 4;
                Console.WriteLine("Step " + i + ": " + number);
                i++;
            }
            do
            {
                Console.WriteLine("The current value is " + number);
                Console.WriteLine("Would you like to double this number? (yes or true to double)");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "yes":
                        number *= 2;
                        repeat = true;
                        break;
                    case "true":
                        number *= 2;
                        repeat = true;
                        break;
                    default:
                        repeat = false;
                        break;
                }  

            }
            while (repeat == true);
        }
    }
}
