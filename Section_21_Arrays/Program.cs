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


            foreach(int i in a) {
               Console.WriteLine(i);
            }

            Console.WriteLine();

            foreach(string i in b) {
                Console.WriteLine(i);
            }

            //reverse
            for (int i = b.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(b[i]);
            }


            Console.ReadKey();
        }
    }
}
