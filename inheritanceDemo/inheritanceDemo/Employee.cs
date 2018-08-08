using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDemo
{
    class Employee : Person, IQuittable
    {
        public Employee (string fname, string lname, int newid = 0)
        {
            this.Id = newid;
            this.FirstName = fname;
            this.LastName = lname;
        }

        public int Id { get; set; } = 0;

        public void Quit()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " has quit the company");
        }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            return ((emp1.FirstName == emp2.FirstName) && (emp1.LastName == emp2.LastName) && (emp1.Id == emp2.Id));
        }

        public static bool operator!= (Employee emp1, Employee emp2)
        {
            return ((emp1.FirstName != emp2.FirstName) || (emp1.LastName != emp2.LastName) || (emp1.Id != emp2.Id));
        }

        public bool Equals(Employee emp)
        {
            return ((emp.FirstName == this.FirstName) && (emp.LastName == this.LastName) && (emp.Id == this.Id));
        }
    }
}
