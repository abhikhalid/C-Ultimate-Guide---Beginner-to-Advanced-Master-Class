using Arrays_Of_Obejcts_Class_Library;
using System;

namespace Arrays_Of_Objects_ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //create object of Employee class
            Employee employee1 = new Employee()
            {
                EmpID = 101,
                EmpName = "Khalid"
            };

            Employee employee2 = new Employee()
            {
                EmpID = 102,
                EmpName = "Mahmud"
            };

            Employee employee3 = new Employee()
            {
                EmpID = 103,
                EmpName = "Khan"
            };


            //create array of objects
            Employee[] employees = new Employee[] {employee1, employee2,employee3};

            //foreach loop for array of objects
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.EmpID+" "+employee.EmpName);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
