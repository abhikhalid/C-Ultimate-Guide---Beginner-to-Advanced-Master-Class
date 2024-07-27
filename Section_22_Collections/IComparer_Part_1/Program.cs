using System;
using System.Collections.Generic;

namespace IComparer_Part_1
{
    class Employee
    {
        public int EmpID { get; set; }

        public string EmpName { get; set; }

        public string Job { get; set; }
    }

    class CustomComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.EmpID - y.EmpID;
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    EmpID = 104,
                    EmpName = "Mary",
                    Job = "Designer"
                },
                new Employee()
                {
                    EmpID = 102,
                    EmpName = "Alexa",
                    Job = "Manager"
                },
                new Employee()
                {
                    EmpID = 101,
                    EmpName = "Steven",
                    Job = "Consultant"
                },
                new Employee()
                {
                    EmpID = 103,
                    EmpName = "Jade",
                    Job = "Analyst"
                },
            };


            CustomComparer customComparer = new CustomComparer();

            employees.Sort(customComparer);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.EmpID+","+employee.EmpName+","
                    +employee.Job);
            }
        }
    }
}
