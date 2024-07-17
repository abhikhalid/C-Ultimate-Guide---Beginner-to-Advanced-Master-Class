using System;

namespace CopyTo_and_Clone_ConsoleApp
{
    class Employee : ICloneable
    {
        public string Employeename { get; set; }
        public string Role { get; set; }


        //public Employee Clone()
        //{
        //    return new Employee()
        //    {
        //        Employeename = this.Employeename,
        //        Role = this.Role
        //    };
        //}

        public object Clone()
        {
            return new Employee()
            {
                Employeename = this.Employeename,
                Role = this.Role
            };
        }
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


            Employee[] employees_deep_copy = new Employee[employees.Length];

            for (int i = 0; i < employees.Length; i++)
            {
                var result = (Employee)employees[i].Clone();
                employees_deep_copy[i] = result;
            }

      

            employees[0].Employeename = "Israr";

            Console.WriteLine("Before Deep Copy\n");

            foreach (Employee emp in employees)
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

            Console.WriteLine("After Deep Copy\n");


            //print destination array
            foreach (Employee emp in employees_deep_copy)
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

          

            Console.ReadKey();

        }
    }
}
