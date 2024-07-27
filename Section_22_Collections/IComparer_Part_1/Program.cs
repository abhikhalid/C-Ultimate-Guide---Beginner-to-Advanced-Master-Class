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

    public enum SortBy
    {
        EmpID, Empname, Job
    }

    class CustomComparer : IComparer<Employee>
    {
        //Sort by EmpID
        //public int Compare(Employee x, Employee y)
        //{
        //    return x.EmpID - y.EmpID;
        //}

        //Sort By EmpName
        //public int Compare(Employee x, Employee y)
        //{
        //    return x.EmpName.CompareTo(y.EmpName);
        //}

        //Sort By Job,EmpName
        //public int Compare(Employee x, Employee y)
        //{
        //    int result = 0;

        //    if(x.Job != null)
        //    {
        //        result = x.Job.CompareTo(y.Job);
        //    }

        //    if (result == 0)
        //    {
        //        if (x.EmpName != null)
        //        {
        //            result = x.EmpName.CompareTo(y.EmpName);
        //        }
        //    }

        //    return result;
        //}

        //public int Compare(Employee x, Employee y)
        //{
        //    int result = 0;

        //    if (x.Job != null)
        //    {
        //        result = x.Job.CompareTo(y.Job);
        //    }

        //    if (result == 0)
        //    {
        //        if (x.EmpName != null)
        //        {
        //            result = x.EmpName.CompareTo(y.EmpName);
        //        }
        //    }

        //    return result;
        //}


        public SortBy sortBy { get; set; }

        public int Compare(Employee x, Employee y)
        {
            int result = 0;

            switch (this.sortBy)
            {
                case SortBy.EmpID:
                    result = x.EmpID - y.EmpID; break;

                case SortBy.Empname:
                    result = (x.EmpName!=null) ? x.EmpName.CompareTo(y.EmpName) : 0; break;
              
                case SortBy.Job:
                    result = (x.Job!=null) ? x.Job.CompareTo(y.Job) : 0; break;
                default:
                    result = 0; break;
            }

            return result;
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
                  new Employee()
                {
                    EmpID = 105,
                    EmpName = "Israr",
                    Job = null
                },
            };


            CustomComparer customComparer = new CustomComparer();
           
            
            customComparer.sortBy = SortBy.EmpID; //this line added later

            employees.Sort(customComparer);
            employees.Reverse();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.EmpID+","+employee.EmpName+","
                    +employee.Job);
            }
        }
    }
}
