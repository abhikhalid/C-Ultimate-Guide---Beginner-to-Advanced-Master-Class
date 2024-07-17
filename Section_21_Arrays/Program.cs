using System;

namespace Section_21_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create array
            int[] a = new int[] { 10, 20, 30 };

            //resize array to 5
            Array.Resize(ref a,5);

            foreach(int i in a)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
