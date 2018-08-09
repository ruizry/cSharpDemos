using System;

namespace LambdaDemo
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}
