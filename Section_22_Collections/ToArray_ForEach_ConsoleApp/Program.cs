using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToArray_ForEach_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create list
            List<string> myFriends = new List<string>()
            {
                "Scott",
                "Allen",
                "James",
                "Jones"
            };

            //convert to array
            string[] myFrirendArray = myFriends.ToArray();

            //display array
            foreach (string item in myFrirendArray)
            {
                Console.WriteLine(item);
            }


            //forEach method
            myFriends.ForEach(friend => Console.WriteLine(friend));

            Console.ReadKey();
        }
    }
}
