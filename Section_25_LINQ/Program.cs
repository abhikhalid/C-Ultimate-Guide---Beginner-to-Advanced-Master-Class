using System;
using System.Collections.Generic;
using System.Linq;

namespace Section_25_LINQ
{
    class Employee
    {
        public int EmpID { get; set; }

        public string EmpName { get; set; }

        public string  Job { get; set; }

        public string City { get; set; }
    }


    class Temporary
    {
        public bool Check(Employee employee)
        {
            return employee.Job == "Manager";
        }
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
                    EmpName = "Khalid",
                    Job = "Designer",
                    City = "Dhaka"
                },
                 new Employee()
                {
                    EmpID = 102,
                    EmpName = "Mahmud",
                    Job = "Developer",
                    City = "Pabna"
                },
                new Employee()
                {
                    EmpID = 103,
                    EmpName = "Khan",
                    Job = "Analyst",
                    City = "Rajshahi"
                },
                new Employee()
                {
                    EmpID = 104,
                    EmpName = "Abhi",
                    Job = "Manager",
                    City = "Dhaka"
                },
                new Employee()
                {
                    EmpID = 105,
                    EmpName = "Israr",
                    Job = "Manager",
                    City = "Pabna"
                },
            };

            foreach (Employee item in employees)
            {
                
            }

            // Where method contains foreach loop internally

            //var result = employees.Where(emp => emp.Job == "Manager");
            //var result = employees.Where(emp => emp.City == "Pabna");
            IEnumerable<Employee> result = employees.Where(emp => emp.City == "Pabna");

            foreach (Employee item in result)
            {
                Console.WriteLine(item.EmpID+","+item.EmpName+","+item.Job+
                    ","+item.City);                
            }

            Console.ReadKey();
        }
    }
}
