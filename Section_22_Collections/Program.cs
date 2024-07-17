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

            //read elements using foreach loop
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //read elements using for loop
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }


            Console.ReadKey();
        }
    }
}
