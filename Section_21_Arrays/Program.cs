using System;

namespace Section_21_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create array
            int[] a = new int[] { 67, 12, 99, 4, 500, 125 };

            //sort ascending order
            Array.Sort(a);

            //display array after sort
            foreach(int item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
