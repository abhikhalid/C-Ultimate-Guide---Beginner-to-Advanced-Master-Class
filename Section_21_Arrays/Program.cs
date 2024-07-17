using System;

namespace Section_21_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create array
            int[] a = new int[] {10, 20, 30,40,50,60};

            //clear elements of array
            Array.Clear(a,2,3);

            foreach (int item in a) {
              System.Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
