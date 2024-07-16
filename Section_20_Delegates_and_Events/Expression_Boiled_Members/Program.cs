using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Boiled_Members
{
    class Student
    {
        //private field
        private string _studentName;

        //public method
        /*
        public int GetStudentNameLength()
        {
            return _studentName.Length;
        }
        */
        //for this kind of methods exactly, we can use Expression Bodied Members Syntax
        public int GetStdentLength() => _studentName.Length;

        //public constructor
        public Student() => _studentName = "Khalid";

        //public properties
        public string StudentName
        {
            set => _studentName = value;

            get => _studentName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { StudentName = "Khalid"};

            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.GetStdentLength());

            Console.ReadKey();
        }
    }
}
