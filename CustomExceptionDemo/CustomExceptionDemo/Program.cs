using System;

namespace CustomExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age please");
            YourAge age;
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                age = new YourAge(input);
            }
            catch (ZeroHandler)
            {
                Console.WriteLine("Enter a non-zero number please");
                Console.ReadLine();
                return;
            }
            catch (NegativeHandler)
            {
                Console.WriteLine("Enter a positive value please");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
                Console.ReadLine();
                return;
            }

            int year = ((18 - age.Age) + 100) % 100;
            Console.WriteLine("\nYou were born in '" + year.ToString("00"));

            Console.WriteLine("\nEnd of program, press enter to exit");
            Console.ReadLine();
        }
    }

    public class YourAge
    {
        public int Age;

        public YourAge(int a)
        {
            if (a == 0) throw new ZeroHandler();
            else if (a < 0) throw new NegativeHandler();
            else Age = a;
        }
    }

    public class ZeroHandler : Exception
    {
        public ZeroHandler()
            : base() { }
        public ZeroHandler(string message)
            : base(message) { }
    }

    public class NegativeHandler : Exception
    {
        public NegativeHandler()
            : base() { }
        public NegativeHandler(string message)
            : base(message) { }
    }
}
