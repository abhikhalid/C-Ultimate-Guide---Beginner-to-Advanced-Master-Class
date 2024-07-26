using System;
using System.Collections.Generic;

namespace Object_Relation_One_To_Many_Class_Library
{
    /// <summary>
    /// Represents a Student
    /// </summary>
    public class Student
    {
        public int RollNo { get; set; }

        public string StudentName { get; set; }

        public string Email { get; set; }

        //one-to-many relationship
        public List<Examination> examinations { get; set; }
    }
}
