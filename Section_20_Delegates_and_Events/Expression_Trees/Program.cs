using System;
using System.Linq.Expressions;

namespace Expression_Trees
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //create object of Student class
            Student student = new Student() { StudentID = 101, StudentName = "Khalid", Age = 15};

            //create expression tree with Func
            Expression<Func<Student, bool>> expression = s => s.Age > 12 && s.Age < 20;

            //Compile expresion using Compile method to invoke it as a Delegate
            Func<Student, bool> myDelegate = expression.Compile();

            //Execute the method
            bool result = myDelegate.Invoke(student);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
