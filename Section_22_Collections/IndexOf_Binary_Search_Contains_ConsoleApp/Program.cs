using System;
using System.Collections.Generic;

namespace IndexOf_Binary_Search_Contains_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50,40};

            //search for 40
            int n = myList.IndexOf(40);
            Console.WriteLine("40 is found at " + n);

            int n2 = myList.IndexOf(60);

            if (n2 >= 0)
            {
                Console.WriteLine("60 is found at" + n2);
            }
            else
            {
                Console.WriteLine("60 is not found");
            }


            //search for second occurrence of 40
            int n3 = myList.IndexOf(40, n + 1);
            Console.WriteLine("Second occurrence of 40 is " + n3);


            //collection for binary search 
            List<int> myList2 = new List<int>() {10,20,30,40,50,60,70,80,90,100};
            int n4 = myList2.BinarySearch(80);

            Console.WriteLine("Binary serach of 80: " + n4);

            //contains
            bool b = myList2.Contains(110);
            Console.WriteLine("110 is found in myList2: " + b);

            Console.ReadKey();
        }
    }
}
