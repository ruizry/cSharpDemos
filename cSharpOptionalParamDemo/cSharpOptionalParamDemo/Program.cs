using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOptionalParamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput1 = 0;
            string stringinput2 = "";
            int userinput2 = 0;

            PowersDemo mathinstance = new PowersDemo();
            Console.WriteLine("Please enter the first number that will be passed as an integer to the powers method (this input is required)");
            userinput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number that will be passed as an integer to the powers method (this input is optional)");
            stringinput2 = Console.ReadLine();
            if (string.IsNullOrEmpty(stringinput2))
            {
                Console.WriteLine("No second input");
                Console.WriteLine("Base " + userinput1 + " to the power of 1: " + mathinstance.powers(userinput1));
            }
            else
            {
                Console.WriteLine("Second input received");
                userinput2 = Convert.ToInt32(stringinput2);
                Console.WriteLine("Base " + userinput1 + " to the power of " + userinput2 + " is: " + mathinstance.powers(userinput1, userinput2));
            }

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
