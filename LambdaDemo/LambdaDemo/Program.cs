using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee tempEmp = new Employee("John", "Adams", 0);
            employees.Add(tempEmp);
            tempEmp = new Employee("Jacob", "Mills", 1);
            employees.Add(tempEmp);
            tempEmp = new Employee("Lindsey", "Mitchell", 2);
            employees.Add(tempEmp);

            for (int i = 3; i < 10; i++)
            {
                tempEmp = new Employee("Joe", "Rogers", i);
                employees.Add(tempEmp);
            }

            Console.WriteLine("List of 10 employees added to initial list");

            foreach (Employee e in employees)
            {
                Console.WriteLine("Employee ID: " + e.Id + " First Name: " + e.FirstName);
            }

            Console.WriteLine("\nUsing Foreach loop to create a new Employee list to include all employees named Joe");
            List<Employee> newEmployees = new List<Employee>();

            foreach (Employee e in employees)
            {
                if (e.FirstName == "Joe")
                {
                    newEmployees.Add(e);
                }
            }

            foreach (Employee e in newEmployees)
            {
                Console.WriteLine("Employee ID: " + e.Id + " First Name: " + e.FirstName);
            }

            Console.WriteLine("\nUsing a lambda expression to create new Employee list to include all employees named Joe with an Id greater than 5");

            List<Employee> newEmployees2 = employees.Where(x => x.Id > 5 && x.FirstName == "Joe").ToList();

            foreach (Employee e in newEmployees2)
            {
                Console.WriteLine("Employee ID: " + e.Id + " First Name: " + e.FirstName);
            }

            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();

        }
    }
}
