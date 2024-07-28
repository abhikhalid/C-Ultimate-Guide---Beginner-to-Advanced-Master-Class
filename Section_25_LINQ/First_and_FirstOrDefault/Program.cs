using System;
using System.Collections.Generic;
using System.Linq;

namespace Section_25_LINQ
{
    class Employee
    {
        public int EmpID { get; set; }

        public string EmpName { get; set; }

        public string Job { get; set; }

        public double Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    EmpID = 101,
                    EmpName = "Henry",
                    Job = "Designer",
                    Salary = 7232
                },
                 new Employee()
                {
                    EmpID = 102,
                    EmpName = "Jack",
                    Job = "Developer",
                    Salary = 4500
                },
                new Employee()
                {
                    EmpID = 103,
                    EmpName = "Gabriel",
                    Job = "Analyst",
                    Salary = 1293
                },
                new Employee()
                {
                    EmpID = 104,
                    EmpName = "William",
                    Job = "Manager",
                    Salary = 2873
                },
                new Employee()
                {
                    EmpID = 105,
                    EmpName = "Alexa",
                    Job = "Manager",
                    Salary = 6232
                },
            };

            //Where returns multiple values as IEnumerable

            //IEnumerable<Employee> filteredEmployees = employees.Where(emp => emp.Job == "Manager");
            List<Employee> filteredEmployees = employees.Where(emp => emp.Job == "Manager").ToList();
            // now I can acess using index
            Console.WriteLine(filteredEmployees[0].EmpID + "," + filteredEmployees[0].EmpName);


            //But what if I am interested only in the first matching elemnt not the remaining?

            //First
            Employee firsManager = employees.First(emp => emp.Job == "Manager");
            //Employee firsManager = employees.First(emp => emp.Job == "Section Head");
            Console.WriteLine(firsManager.EmpID + "," + firsManager.EmpName);

            //FirstOrDefault
            Employee firsManager2 = employees.FirstOrDefault(emp => emp.Job == "Section Head");

            if (firsManager2 != null)
            {
                Console.WriteLine(firsManager2.EmpID + "," + firsManager2.EmpName);
            }
            else
            {
                Console.WriteLine("No section head in the list");
            }
            
            Console.ReadKey();
        }
    }
}
