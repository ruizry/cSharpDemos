using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for this multiplication demo");
            int firstVal = Convert.ToInt32(Console.ReadLine());
            int firstResult = firstVal * 50;
            Console.WriteLine("Your number multiplied by 50: " + firstResult);
            Console.WriteLine("Please enter a number for this addition demo");
            int secondVal = Convert.ToInt32(Console.ReadLine());
            int secondResult = secondVal + 25;
            Console.WriteLine("Your number after 25 is added: " + secondResult);
            Console.WriteLine("Please enter a number for this division demo");
            double thirdVal = Convert.ToDouble(Console.ReadLine());
            double thirdResult = thirdVal / 12.5;
            Console.WriteLine("Your number after being divided by 12.5: " + thirdResult);
            Console.WriteLine("Please enter a number for this compare operator demo");
            int fourthVal = Convert.ToInt32(Console.ReadLine());
            bool fourthResult = fourthVal > 50;
            Console.WriteLine("Is your number greater than 50?: " + fourthResult);
            Console.WriteLine("Please enter a number for this remainder demo");
            int fifthVal = Convert.ToInt32(Console.ReadLine());
            int fifthResult = fifthVal % 7;
            Console.WriteLine("Remainder of your number being divided by 7: " + fifthResult);
            Console.ReadLine();
        }
    }
}
