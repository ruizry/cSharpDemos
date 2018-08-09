using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDemo
{
    class Employee<T> : Person, IQuittable
    {
        public int Id { get; private set; } = 0;
        public List<T> things { get; private set; }

        public Employee (string fname, string lname, List<T> newthings, int newid = 0)
        {
            this.Id = newid;
            this.FirstName = fname;
            this.LastName = lname;
            things = newthings;
        }

        public void Quit()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " has quit the company");
        }

        public static bool operator== (Employee<T> emp1, Employee<T> emp2)
        {
            return ((emp1.FirstName == emp2.FirstName) && (emp1.LastName == emp2.LastName) && (emp1.Id == emp2.Id));
        }

        public static bool operator!= (Employee<T> emp1, Employee<T> emp2)
        {
            return ((emp1.FirstName != emp2.FirstName) || (emp1.LastName != emp2.LastName) || (emp1.Id != emp2.Id));
        }

        public bool Equals(Employee<T> emp)
        {
            return ((emp.FirstName == this.FirstName) && (emp.LastName == this.LastName) && (emp.Id == this.Id));
        }
    }
}
