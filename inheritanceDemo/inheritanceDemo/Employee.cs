using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDemo
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; } = 0;

        public void Quit()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " has quit the company");
        }
    }
}
