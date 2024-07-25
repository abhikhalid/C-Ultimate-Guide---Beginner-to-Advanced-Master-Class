using System;
using System.Collections;

namespace ArrayList1
{
    class Sample
    {
        public int GetNumber()
        {
            return 10;
        }

        public double GetAnotherNumber()
        {
            return 10.7;
        }

        public string GetMessage()
        {
            return "Hello";
        }

        public Employee GetEmployee()
        {
            return new Employee() { EmployeeName = "Khalid" };
        }
    }

    public class Employee
    {
        public string EmployeeName { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //Create object of ArrayList class
            ArrayList arrayList = new ArrayList() { 100, 'A' };

            Sample sample = new Sample();

            //Add
            arrayList.Add(sample.GetNumber());
            arrayList.Add(sample.GetAnotherNumber());
            arrayList.Add(sample.GetMessage());
            arrayList.Add(sample.GetEmployee());

            //foreach
            foreach (var item in arrayList)
            {
                //Pattern Matching Syntax
                if (item is Employee emp)
                {
                    Console.WriteLine(emp.EmployeeName);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }

}
