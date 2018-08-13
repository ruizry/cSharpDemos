using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to log to a file");
            string number = Console.ReadLine();
            File.WriteAllText(@".\log.txt", number);
            Console.WriteLine("Number successfully logged\n\nNow reading log and outputting contents to console:");

            string input = File.ReadAllText(@".\log.txt");
            Console.WriteLine(input);

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }
}
