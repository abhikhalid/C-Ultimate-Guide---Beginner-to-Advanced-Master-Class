using System;

namespace CopyTo_and_Clone_ConsoleApp
{
    class Employee
    {
        public string Employeename { get; set; }
        public string Role { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee(){Employeename="Khalid",Role="Developer"},
                new Employee(){Employeename="Mahmud",Role="Hero"},
                new Employee(){Employeename="Khan",Role="Designer"},
            };

            //new array
            Employee[] highlyPaidEmployees = new Employee[3];
           
            //Copy To
            employees.CopyTo(highlyPaidEmployees,0);


            //print destination array
            foreach(Employee emp in highlyPaidEmployees)
            {
                if(!(emp is null))
                {
                    Console.WriteLine(emp.Employeename + "," + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            Console.WriteLine();

            //Clone
            Employee[] highlyPaidEmployees2 = (Employee[])employees.Clone(); //creates a new array & copies from source array to new array
            
            foreach (Employee emp in highlyPaidEmployees2)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(emp.Employeename + "," + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }


            //Copy To method expects that there is an array before execution of the copy to method
            //Clone method creates a new array by itself

            Console.ReadKey();

        }
    }
}
