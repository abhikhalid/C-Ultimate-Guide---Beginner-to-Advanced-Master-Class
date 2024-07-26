using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Relation_One_To_One_Class_Library
{
    public class Student
    {
        public int RollNo { get; set; }

        public string StudentName { get; set; }

        public string Email { get; set; }

        // object relation
        //contains reference to object of Branch class, that represents the branch that the current student belongs to. 
        public Branch branch { get; set; } 
    }
}
