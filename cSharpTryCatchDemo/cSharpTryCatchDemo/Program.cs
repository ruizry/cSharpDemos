using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTryCatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 5, 25, 100, 90, 76, 33, 94, 1000, 5400, 12250 };
            Console.WriteLine("Please enter a number that will divide into all numbers in a list");
            try
            {
                int divisor = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                int iterator = 0;
                while (iterator < intList.Count)
                {
                    result = intList[iterator] / divisor;
                    Console.WriteLine("Element " + iterator + " value: " + intList[iterator] + ". Result of this number being divided by " + divisor + ": " + result);
                    iterator++;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("You cannot divide by a value that is not a number");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nEnd of the program, push enter to exit");
                Console.ReadLine();
            }
        }
    }
}
