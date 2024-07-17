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

            //add new element at the end of existing collection
            myList.Add(40);

            //another collection
            List<int> otherList = new List<int>() { 50, 60, 70 };

            //adding another collection to existing collection
            myList.AddRange(otherList);


            Console.WriteLine("Using foreach loop:");
            //read elements using foreach loop
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
