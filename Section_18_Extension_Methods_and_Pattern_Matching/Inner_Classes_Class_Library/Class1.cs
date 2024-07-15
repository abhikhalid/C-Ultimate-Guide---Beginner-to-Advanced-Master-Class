using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_Classes_Class_Library
{
    public class Student
    {
        public double SecuredMarks { get; set; }
        public double MaxMarks { get; set; }
        public double Percentage { get; set; }
    }

    //outer class
    public class MarksCalculation
    {
        public void CalculatePercentage(Student s)
        {
            //create object of inner class
            CalculationHelper ch = new CalculationHelper();
            s.Percentage = ch.Multipy(s.SecuredMarks / s.MaxMarks,100);
        }

        //inner class
        public class CalculationHelper
        {
            public double Multipy(double n1, double n2)
            {
                return n1 * n2;
            }
        }
    }
}
