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

            
            //IOrderedEnumerable interface represnts that our data is sorted.
            //IOrderedEnumerable<Employee> sortedEmployees = employees.OrderBy(emp => emp.EmpName);
            //IEnumerable<Employee> sortedEmployees = employees.OrderBy(emp => emp.EmpName);
            //IEnumerable<Employee> sortedEmployees = employees.OrderByDescending(emp => emp.EmpName);

            //IEnumerable<Employee> sortedEmployees = employees.OrderByDescending(emp => emp.Job);

            //IEnumerable<Employee> sortedEmployees = employees
            //    .OrderBy(emp => emp.Job)
            //    .ThenBy(emp => emp.EmpName);


            IEnumerable<Employee> sortedEmployees = employees
                .OrderByDescending(emp => emp.Job)
                .ThenByDescending(emp => emp.EmpName);


            foreach (Employee item in sortedEmployees)
            {
                Console.WriteLine(item.EmpID + "," + item.EmpName + "," + item.Job +
                    "," + item.Salary);
            }

            Console.ReadKey();
        }
    }
}
