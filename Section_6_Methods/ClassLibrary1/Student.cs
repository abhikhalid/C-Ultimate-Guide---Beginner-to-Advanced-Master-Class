using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public int grade = 2;

        public void PrintGrade()
        {
            System.Console.WriteLine("Grade:" + grade);
        }

        //public method with ref return
        public ref int DoWork()
        {
            //return reference of 'grade' field
            return ref grade;
        }
    }
}
