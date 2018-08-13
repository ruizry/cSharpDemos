using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The time is " + now);
            Console.WriteLine("How many hours would you like to advance time?");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime later = now + new TimeSpan(hours, 0, 0);
            Console.WriteLine("\nThe time after being advanced will be " + later);

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
