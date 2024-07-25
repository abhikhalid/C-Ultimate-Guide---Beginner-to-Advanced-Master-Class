using System;
using System.Collections.Generic;

namespace Stack
{
    class Student
    {
        public int Marks { get; set; }
        public int Rank { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //create object of Stack
            Stack<Student> marks = new Stack<Student>();

            //Add
            marks.Push(new Student() { Marks = 45});
            marks.Push(new Student() { Marks = 61});
            marks.Push(new Student() { Marks = 80});


            //Pop
            Student stu = marks.Pop();
            Console.WriteLine("Pop: "+stu.Marks);

            //Peek
            Student student = marks.Peek();
            Console.WriteLine("Peek : " + student.Marks);

            int r = 1;

            foreach (var item in marks)
            {
                item.Rank = r++;
                Console.WriteLine(item.Marks + ", "+ item.Rank);
            }

            Console.ReadKey();
        }
    }
}
