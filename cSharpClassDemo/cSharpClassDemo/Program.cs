using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput = 0;
            SimpleMathClass mathinstance = new SimpleMathClass();
            Console.WriteLine("Please enter number to test addTwo method");
            userinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of " + userinput + " being plugged into the addTwo method: " + mathinstance.addTwo(userinput));

            Console.WriteLine("\nPlease enter number to test subtractTen method");
            userinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of " + userinput + " being plugged into the addTwo method: " + mathinstance.subtractTen(userinput));

            Console.WriteLine("\nPlease enter number to test multipleByThree method");
            userinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of " + userinput + " being plugged into the addTwo method: " + mathinstance.multipleByThree(userinput));

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
