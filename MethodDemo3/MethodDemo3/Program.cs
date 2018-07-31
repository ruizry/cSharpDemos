using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput1 = 0;

            int remainder = 0;

            divideByTwoClass mathinstance = new divideByTwoClass();

            Console.WriteLine("Please enter a number that will be divided by two");
            userinput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userinput1 + " divided by 2 is: ");
            mathinstance.divideByTwo(userinput1, out remainder);

            Console.WriteLine("The remainder from our out parameter is: " + remainder);

            Console.WriteLine("\nMethod from static class being called: ");
            StaticClass.printSomething();
            Console.WriteLine("\nPlease enter how many times to repeat the previous message");

            userinput1 = Convert.ToInt32(Console.ReadLine());
            StaticClass.printSomething(userinput1);

            Console.WriteLine("\nOverloaded method called");

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
