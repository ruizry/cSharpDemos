using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIterationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteration = 0;
            string userinput;

            string[] strArray = new string[] { "-cat", "-dog", "-lizard", "-parrot", "-rabbit", "-frog" };

            Console.WriteLine("Please enter a name for a pet:");
            userinput = Console.ReadLine();

            Console.WriteLine("Your name when added to the array of pets stored in this program");
            for (iteration = 0; iteration < strArray.Length; iteration++)
            {
                Console.WriteLine("Pet " + iteration + ": " + userinput + strArray[iteration]);
            }

            Console.WriteLine("\nHere is a demo of an infinite loop");
            Console.WriteLine("This loop will fix itself after 2000 iterations, press enter to start and please wait");
            Console.ReadLine();

            while (1 == 1)
            {
                iteration++;
                Console.WriteLine("iteration " + iteration);
                if (iteration == 2000)
                    break;

            }

            Console.WriteLine("Out of infinite loop");

            Console.WriteLine("\nDemo for < comparator to list array index values, press enter to start");
            Console.ReadLine();

            for (iteration = 0; iteration < strArray.Length; iteration++)
            {
                Console.WriteLine("strArray index: " + iteration + " value: " + strArray[iteration]);
            }

            Console.WriteLine("\nDemo for <= comparator to count all elements in the array, press enter to start");
            Console.ReadLine();

            for (iteration = 1; iteration <= strArray.Length; iteration++)
            {
                Console.WriteLine("strArray element: " + iteration + " value: " + strArray[iteration - 1]);
            }

            List<string> stringList = new List<string>();
            stringList.Add("beef");
            stringList.Add("pork");
            stringList.Add("chicken");
            stringList.Add("fish");
            stringList.Add("vegetarian");
            stringList.Add("shrimp");

            iteration = 0;
            Console.WriteLine("\nDemo for using iteration to search through a list with unique values");
            Console.WriteLine("Below is the contents of the list\n");
            while (iteration < stringList.Count)
            {
                Console.Write(stringList[iteration] + " ");
                iteration++;
            }
            int index = -1;
            iteration = 0;
            bool found = false;
            Console.WriteLine("\n\nPlease enter a value from the list to find its index");
            userinput = Console.ReadLine();
            while (iteration < stringList.Count && !found)
            {
                if(stringList[iteration] == userinput)
                {
                    found = true;
                    index = iteration;
                }
                iteration++;
            }

            if (index >= 0)
                Console.WriteLine("Index of " + userinput + ": " + index);
            else
                Console.WriteLine("Element not found");


            List<string> stringList2 = new List<string>();
            stringList2.Add("beef");
            stringList2.Add("pork");
            stringList2.Add("chicken");
            stringList2.Add("fish");
            stringList2.Add("vegetarian");
            stringList2.Add("shrimp");
            stringList2.Add("beef");
            stringList2.Add("pork");
            stringList2.Add("chicken");
            stringList2.Add("fish");
            stringList2.Add("vegetarian");
            stringList2.Add("shrimp");

            iteration = 0;
            Console.WriteLine("\nDemo for using iteration to search through a list with some repeated values");
            Console.WriteLine("Below is the contents of the list\n");
            while (iteration < stringList2.Count)
            {
                Console.Write(stringList2[iteration] + " ");
                iteration++;
            }

            List<int> intlist = new List<int>();
            iteration = 0;
            Console.WriteLine("\n\nPlease enter a value from the list to find its index");
            userinput = Console.ReadLine();
            while (iteration < stringList2.Count)
            {
                if (stringList2[iteration] == userinput)
                {
                    intlist.Add(iteration);
                }
                iteration++;
            }

            if (intlist.Count > 0)
            {
                Console.WriteLine("How many elements found: " + intlist.Count);
                Console.Write("Indicies of the elements found: ");
                iteration = 0;
                while ( iteration < intlist.Count)
                {
                    Console.Write(intlist[iteration] + " ");
                    iteration++;
                }
            }
            else
                Console.WriteLine("Element not found anywhere in list");

            /*
            foreach exercise here
            */
            Console.WriteLine("\n\nDemo using foreach to iterate through a list, press enter to start");
            Console.ReadLine();

            found = false;
            int counter = 0;
            foreach (string element in stringList2)
            {
                Console.WriteLine("Value at index " + counter + ": " + element);
                found = false;
                iteration = 0;
                while (iteration < counter && !found)
                {
                    if (stringList2[iteration] == element)
                    {
                        found = true;
                    }
                    iteration++;
                }
                if (found)
                {
                    Console.WriteLine("This value was found before");
                }
                else
                {
                    Console.WriteLine("This value was not found before");
                }
                counter++;
            }

            Console.WriteLine("\nProgram over, press enter to exit");
            Console.ReadLine();
        }
    }
}
