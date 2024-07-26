using Object_Relation_Many_To_One_Class_Library;
using System;
using System.Security.Cryptography;

namespace Object_Relation_Many_To_One_ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee()
            {
                EmployeeID = 1,
                EmployeeName = "Khalid",
                Email = "khalid@gmail.com"
            };  
            
            Employee employee2 = new Employee()
            {
                EmployeeID = 2,
                EmployeeName = "Mahmud",
                Email = "mahmud@gmail.com"
            };
            
            Employee employee3 = new Employee()
            {
                EmployeeID = 3,
                EmployeeName = "Khan",
                Email = "khan@gmail.com"
            };

            //create object of Department class
            Department department = new Department()
            {
                DepartmentID = 10,
                DepartmentName = "Accounting"
            };

            //establishing many to one relatioship.
            //Many employee has one department object.
            employee1.department = department;
            employee2.department = department;
            employee3.department = department;

            //Print
            Console.WriteLine("First Employee");
            Console.Write("Employee ID : " + employee1.EmployeeID);
            Console.Write("Name : " + employee1.EmployeeName);
            Console.Write("Email : " + employee1.Email);
            Console.Write("Department ID:" + employee1.department.DepartmentID);
            Console.Write("Department Name: " + employee1.department.DepartmentName);


            Console.WriteLine("Second Employee");
            Console.Write("Employee ID : " + employee2.EmployeeID);
            Console.Write("Name : " + employee2.EmployeeName);
            Console.Write("Email : " + employee2.Email);
            Console.Write("Department ID:" + employee2.department.DepartmentID);
            Console.Write("Department Name: " + employee2.department.DepartmentName);

            Console.WriteLine("Third Employee");
            Console.Write("Employee ID : " + employee3.EmployeeID);
            Console.Write("Name : " + employee3.EmployeeName);
            Console.Write("Email : " + employee3.Email);
            Console.Write("Department ID:" + employee3.department.DepartmentID);
            Console.Write("Department Name: " + employee3.department.DepartmentName);

            //Challenge: Make these employees as Collection and you can accept all the details from the keyboard as long as the user says yes to continue.

            Console.ReadKey();
        }
    }
}
