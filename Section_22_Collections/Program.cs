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
            myList = new List<int>(10) { 10,20,30,40,50}; //it's better if you sure the initial size, it improves the performance.


            //remove 30
            //myList.Remove(30);

            //remove at Index 2
            // myList.RemoveAt(2);
            //myList.RemoveAt(5); // ArgumentOutOfRangeException

            /*
            int ind = 5;
            if(ind < myList.Count)
            {
                myList.RemoveAt(ind);
                Console.WriteLine("Removed");
            }
            */

            //remove range starts from index 1, count is 2 elements
            //myList.RemoveRange(1, 2);

            //RemoveAll (remove all numbers > 30)

            //lamda expression
            myList.RemoveAll(n => n>=30);

            myList.Clear();


            Console.WriteLine("Using foreach loop:");
            foreach (int item in myList)
            {
                Console.WriteLine(item); // 10 100 20 30
            }

            Console.ReadKey();
        }
    }
}
