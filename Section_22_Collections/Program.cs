using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_22_Collections
{
    class Program
    {
        static void Main()
        {
            //create reference variable for List Class
            List<int> myList;

            //create object of List class
            //myList = new List<int>() { 10,20,30};
            myList = new List<int>(10) { 10,20,30}; //it's better if you sure the initial size, it improves the performance.


            //insert element at position 1
            myList.Insert(1, 100);


            //insert elements at position 2
            List<int> otherList = new List<int>() { 200, 300, 400 };

            myList.InsertRange(2, otherList);


            Console.WriteLine("Using foreach loop:");
            foreach (int item in myList)
            {
                Console.WriteLine(item); // 10 100 20 30
            }

            Console.ReadKey();
        }
    }
}
