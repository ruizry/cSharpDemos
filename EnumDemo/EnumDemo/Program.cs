using System;

namespace EnumDemo
{
    class Program
    {
        enum DayOfTheWeek { monday, tuesday, wednesday, thursday, friday, saturday, sunday };

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please tell me what day of the week it is today");
                string input = Console.ReadLine().ToLower();
                //Console.WriteLine(DayOfTheWeek.IsDefined(typeof(DayOfTheWeek), input));
                DayOfTheWeek day = (DayOfTheWeek) Enum.Parse(typeof(DayOfTheWeek), input);

                Console.WriteLine("\nThank you, the day for today is set to: " + day.ToString());

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Not a valid enum: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
            }
            finally
            {
                Console.WriteLine("\nThis is the end of the program, press enter to exit");
                Console.ReadLine();
            }
        }
    }
}
