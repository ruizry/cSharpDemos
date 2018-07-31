using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo3
{
    static class StaticClass
    {
        static public void printSomething()
        {
            Console.WriteLine("Hello, static class method successfully called");
        }
        static public void printSomething(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine("Hello, static class method successfully called");
            }
        }
    }
}
