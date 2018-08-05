using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDemo
{
    class Employee : Person
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }

        public Employee(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
    }
}
