using System;

namespace Section_21_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an array

            //since the data type is int - that is the numerical type - the default value for int is 0
            int[] a = new int[5] {10,20,30,40,50};
            string[] b = new string[5] {"one","two","three","four","five"};


            //display the values of elements
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);
            //Console.WriteLine(a[5]); // Index out of Range Exception

            Console.WriteLine(b[0]);
            Console.WriteLine(b[1]);
            Console.WriteLine(b[2]);
            Console.WriteLine(b[3]);
            Console.WriteLine(b[4]);


            Console.ReadKey();
        }
    }
}
