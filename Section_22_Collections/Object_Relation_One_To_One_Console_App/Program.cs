using Object_Relation_One_To_One_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Relation_One_To_One_Console_App
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.RollNo = 123;
            student.StudentName = "Khalid";
            student.Email = "khalid@gmail.com";

            //Branch br = new Branch();
            //br.BranchName = "Computer Science Engineering";
            //br.NoOfSemester = 8;

            ////one-to-one releation
            //student.branch = br;

            //or
            student.branch = new Branch();
            student.branch.BranchName = "Computer Science Engineering";
            student.branch.NoOfSemester = 8;

            //display
            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.branch.BranchName);
            Console.WriteLine(student.branch.NoOfSemester);

            Console.ReadKey();
        }
    }
}
