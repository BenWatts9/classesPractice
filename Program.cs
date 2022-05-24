using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            
            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            Employee emp1 = new Employee()
            {
                FirstName = "Man",
                LastName = "Dana",
                StartDate = new DateTime(1989, 2, 25),
                Position = "Flip Flop Guy"
            };
            Employee emp2 = new Employee()
            {
                FirstName = "Ben",
                LastName = "Watts",
                StartDate = new DateTime(2022, 1, 14),
                Position = "Cool Chill Guy"
            };
            Employee emp3 = new Employee()
            {
                FirstName = "Jersey",
                LastName = "Phil",
                StartDate = new DateTime(1999, 7, 20),
                Position = "Most Aggressive Dude in the Office"
            };

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);

            Company GrassStuff = new Company("GrassNStuff", new DateTime(1963,8,16), employeeList);

            GrassStuff.ListEmployees();
            

        }
            
    }
}