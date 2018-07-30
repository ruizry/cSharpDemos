using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput1 = 0;
            decimal userinput2 = 0.0M;
            string userinput3 = "";

            MultiplyThreeClass mathinstance = new MultiplyThreeClass();
            Console.WriteLine("Please enter a number that will be passed as an integer to test the multiplyByThree method");
            userinput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of " + userinput1 + " being plugged into the multipleByThree method: " + mathinstance.multipleByThree(userinput1));

            Console.WriteLine("\nPlease enter a number that will be passed as a decimal to test the multiplyByThree method");
            userinput2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The result of " + userinput2 + " being plugged into the multipleByThree method: " + mathinstance.multipleByThree(userinput2));

            Console.WriteLine("\nPlease enter a number that will be passed as a string to test the multiplyByThree method");
            userinput3 = Console.ReadLine();
            Console.WriteLine("The result of " + userinput3 + " being plugged into the multipleByThree method: " + mathinstance.multipleByThree(userinput3));

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
