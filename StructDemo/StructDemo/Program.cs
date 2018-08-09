using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a decimal value for creating a Number object");
            decimal val = Convert.ToDecimal(Console.ReadLine());

            Number newNum = new Number(val);

            Console.WriteLine("\nNew Number object created with the following value: " + newNum.myDeci);

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }

        struct Number
        {
            public decimal myDeci { get; }
            public Number(decimal newDeci)
            {
                myDeci = newDeci;
            }
        };
    }
}
