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
                new Employee()
                {
                    EmpID = 105,
                    EmpName = "Siri",
                    Job = "Manager",
                    Salary = 6232
                },
            };

            List<Employee> filteredEmployees = employees.Where(emp => emp.Job == "Manager").ToList();
            // now I can acess using index
            Console.WriteLine(filteredEmployees[filteredEmployees.Count-1].EmpID + "," + filteredEmployees[filteredEmployees.Count - 1].EmpName+","+ filteredEmployees[filteredEmployees.Count - 1].Job);


            //Last
            //Employee lastEmployee = employees.Last(emp => emp.Job == "Manager");
            
            //LastOrDefault
            Employee lastEmployee = employees.LastOrDefault(emp => emp.Job == "Manager");
            
            if(lastEmployee != null)
            {

                Console.WriteLine(lastEmployee.EmpID + "," + lastEmployee.EmpName + "," + lastEmployee.Job);
            }
            else
            {
                Console.WriteLine("No Manager Found!");
            }

            Console.ReadKey();
        }
    }
}
