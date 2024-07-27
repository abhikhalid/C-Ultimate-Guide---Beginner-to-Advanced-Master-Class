using System;
using System.Collections.Generic;

namespace IComparable2
{
    class Employee : IComparable
    {
        public int EmpID { get; set; }

        public string EmpName { get; set; }

        public string Job { get; set; }

        //public int CompareTo(object other)
        //{
        //    Employee otherEmp = other as Employee;
        //    Console.WriteLine(this.EmpID+","+ otherEmp.EmpID);

        //    return this.EmpID - otherEmp.EmpID;
        //}

        public int CompareTo(object other)
        {
            Employee otherEmp = other as Employee;
            Console.WriteLine(this.EmpName + "," + otherEmp.EmpName);

            return this.EmpName.CompareTo(otherEmp.EmpName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            { 
                80,12,77,34
            };

            numbers.Sort();

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //List of employees
            //Collection Initializer
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    EmpID = 104,
                    EmpName = "Mary",
                    Job = "Desinger"
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
                    Job = "Consulant"
                },
                new Employee()
                {
                    EmpID = 103,
                    EmpName = "Jade",
                    Job = "Analyst"
                }
            };


            employees.Sort();

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.EmpID+","+emp.EmpName+","+emp.Job);
            }


            Console.ReadKey();
        }
    }
}
