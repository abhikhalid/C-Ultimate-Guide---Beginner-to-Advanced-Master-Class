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


            for (int i = 0; i < a.Length; i++) {
               Console.WriteLine(a[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < b.Length; i++) {
                Console.WriteLine(b[i]);
            }


            Console.ReadKey();
        }
    }
}
