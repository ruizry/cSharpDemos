using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMethodDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput1 = 0;
            int userinput2 = 0;

            multiplyTwoNumClass mathinstance = new multiplyTwoNumClass();

            Console.WriteLine("Please enter the first number to use for this multiplication method");
            userinput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number to use for this multiplication method");
            userinput2 = Convert.ToInt32(Console.ReadLine());

            mathinstance.multiplyTwo(num1: userinput1, num2: userinput2);
            Console.WriteLine(userinput1 + " multiplied by " + userinput2 + " is: " + mathinstance.result);

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
