using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Relation_One_To_Many_Class_Library
{
    //making this class public so that our console application can use it which is in different assemnly.
    
    
    /// <summary>
    /// Represents examination attempted by the student
    /// </summary>
    public class Examination
    {
        public string ExaminationName { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public int MaxMarks { get; set; }

        public int SecuredMarks { get; set; }
    }
}
