using Pattern_Matching_Class_Library;
using System;
namespace Pattern_Matching_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference variable of parent class
            ParentClass pc;

            //objct of child class
            pc = new ChildClass() { x=10, y=20 };

            //access parent class's members
            Console.WriteLine(pc.x); //but even though it exists in the memory, you will not be able to access the child class's members through the parent class type of reference variable.
            //Console.WriteLine(pc.y); //compile time error

            //access parent class's members
            /*
            if(pc is ChildClass) // whether the object is of child class type.
            {
                ChildClass cc = (ChildClass)pc;
                Console.WriteLine(cc.x);
                Console.WriteLine(cc.y);
            }
            */

            // modern way
            if (pc is ChildClass cc) // This is the new feature introduced in C# which is helpful for converting the parent class's reference variable into the child class's reference variable.
            {
                Console.WriteLine(cc.x);
                Console.WriteLine(cc.y);
            }

            Console.ReadKey();
        }
    }
}
