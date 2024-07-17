using System;

namespace Section_21_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //multi-dim array 4 x 3
            int[,] a = new int[4, 3]
            {
                {10,20,30},
                {40,50,60},
                {70,80,90},
                {100,110,120}
            };

            //read data from multi-dim array
            for(int i = 0;i<4;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    System.Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        // Pracise with 3 or more dimentional array
    }
}
