using System;
using System.Collections.Generic;

namespace cSharpListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int[] numArray = new int[] { 3, 6, 10, 7, 8, 3 };
            string[] strArray = new string[] { "cat", "dog", "lizard", "parrot", "rabbit", "frog" };
            List<string> stringList = new List<string>();
            stringList.Add("beef");
            stringList.Add("pork");
            stringList.Add("chicken");
            stringList.Add("fish");
            stringList.Add("vegetarian");
            stringList.Add("shrimp");

            Console.WriteLine("Please enter an index to attempt to access a member of the string array:");
            index = Convert.ToInt32(Console.ReadLine());
            if (index < strArray.Length)
            {
                Console.WriteLine("Value at index " + index + ": " + strArray[index]);
            }
            else
            {
                Console.WriteLine("Index entered is out of bounds");
            }

            Console.WriteLine("Please enter an index to attempt to access a member of the int array:");
            index = Convert.ToInt32(Console.ReadLine());
            if (index < numArray.Length)
            {
                Console.WriteLine("Value at index " + index + ": " + numArray[index]);
            }
            else
            {
                Console.WriteLine("Index entered is out of bounds");
            }

            Console.WriteLine("Please enter an index to attempt to access a member of the string list:");
            index = Convert.ToInt32(Console.ReadLine());
            if (index < stringList.Count)
            {
                Console.WriteLine("Value at index " + index + ": " + stringList[index]);
            }
            else
            {
                Console.WriteLine("Index entered is out of bounds");
            }

            Console.ReadLine();
        }
    }
}
