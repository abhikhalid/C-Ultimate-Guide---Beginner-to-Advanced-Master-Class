using Object_Relation_One_To_Many_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Relation_One_To_Many_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.RollNo = 1;
            student.StudentName = "Test";
            student.Email = "Test@gmail.com";
            student.examinations = new List<Examination>();

            student.examinations.Add(new Examination()
            {
                ExaminationName = "Module Test 1",
                Month = 5,
                Year = 2021,
                MaxMarks = 100,
                SecuredMarks = 87
            });
            
            student.examinations.Add(new Examination()
            {
                ExaminationName = "Module Test 2",
                Month = 7,
                Year = 2022,
                MaxMarks = 100,
                SecuredMarks = 70
            }); 
            
            student.examinations.Add(new Examination()
            {
                ExaminationName = "Final Test",
                Month = 3,
                Year = 2024,
                MaxMarks = 100,
                SecuredMarks = 91
            });

            //Print
            Console.WriteLine("Roll No: " + student.RollNo);
            Console.WriteLine("Student Name : " + student.StudentName);
            Console.WriteLine("Student Email: " + student.Email);

            foreach (var exam in student.examinations)
            {
                Console.WriteLine(exam.ExaminationName + "," + exam.Year
                    + ","+ exam.Month +","+exam.SecuredMarks+"/"+exam.MaxMarks);
            }

            Console.ReadKey();
        }
    }
}
