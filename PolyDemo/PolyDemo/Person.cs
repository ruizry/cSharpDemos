using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDemo
{
    abstract class Person
    {
        abstract public string FirstName { get; set; }
        abstract public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }
    }
}
