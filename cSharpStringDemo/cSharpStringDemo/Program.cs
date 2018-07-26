using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string catdemo = "";
            StringBuilder paragraph = new StringBuilder();
            StringBuilder sentence = new StringBuilder();
            StringBuilder exit = new StringBuilder();
            exit.Append("exit");

            Console.WriteLine("Please enter 3 strings to concatenate. The second will be entered as all caps.");
            while (i <= 3)
            {
                Console.WriteLine("Please enter string" + i + ":");
                if (i == 2)
                {
                    catdemo += Console.ReadLine().ToUpper();
                }
                else
                {
                    catdemo += Console.ReadLine();
                }
                i++;
            }
            Console.WriteLine("Final string after concatenation: " + catdemo);

            Console.WriteLine("Paragraph builder: Enter 1 sentence at a time");
            Console.WriteLine("Enter a sentence or type exit to finish");
            sentence.Append(Console.ReadLine());
            while (!sentence.Equals(exit))
            {
                paragraph.Append(sentence);
                paragraph.Append(" ");
                sentence.Clear();
                Console.WriteLine("Enter a sentence or type exit to finish");
                sentence.Append(Console.ReadLine());
            }
            Console.WriteLine("Resulting paragraph:");
            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
