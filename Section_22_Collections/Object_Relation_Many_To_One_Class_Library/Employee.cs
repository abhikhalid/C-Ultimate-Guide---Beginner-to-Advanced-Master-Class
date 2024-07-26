using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Relation_Many_To_One_Class_Library
{
    /// <summary>
    /// Represents an employee of the organization
    /// </summary>
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string Email { get; set; }

        //as of this code it is just like one to one relationship. 
        //but in program.cs file, as we are creating multiple employee class that turns out to be the many to one relationship. 
        public Department department { get; set; }
    }
}
