using System;

namespace Dynamically_Typed_var_console
{
    class Student
    {
        public string StudentName;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //dynamically typed variables
            dynamic x;

            x = 100;

            x = "Hello";

            x = new Student() { StudentName = "Khalid"};

            Console.WriteLine(x.StudentName as String); //C# compiler will not check whether the property StudentName exists or not in Student Class

            Console.ReadKey();
        }
    }
}
