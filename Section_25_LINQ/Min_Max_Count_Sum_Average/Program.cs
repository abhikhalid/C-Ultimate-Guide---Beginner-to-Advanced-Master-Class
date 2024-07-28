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
                    Salary = 900
                },
                 new Employee()
                {
                    EmpID = 102,
                    EmpName = "Jack",
                    Job = "Developer",
                    Salary = 1200
                },
                new Employee()
                {
                    EmpID = 103,
                    EmpName = "Gabriel",
                    Job = "Analyst",
                    Salary = 650
                },
                new Employee()
                {
                    EmpID = 104,
                    EmpName = "William",
                    Job = "Manager",
                    Salary = 440
                },
                new Employee()
                {
                    EmpID = 105,
                    EmpName = "Alexa",
                    Job = "Manager",
                    Salary = 1100
                },
                new Employee()
                {
                    EmpID = 105,
                    EmpName = "Siri",
                    Job = "Manager",
                    Salary = 800
                },
            };

            //Min
            double min =  employees.Min(emp => emp.Salary);
            //Max
            double max =  employees.Max(emp => emp.Salary);
            //Sum
            double sum =  employees.Sum(emp => emp.Salary);
            //Avg
            double avg =  employees.Average(emp => emp.Salary);
            //Count
            double cnt =  employees.Count();

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Count: " + cnt);
           

            Console.ReadKey();
        }
    }
}
