using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main()
        {
            //create a sortedlist
            SortedList<int, string> employees = new SortedList<int, string>()
            {
                {101,"Khalid"},
                {102,"Mahmud"},
                {103,"Khan"},
                {104,"Abhi"},
                {105,"Israr"},
            };

            //Add element
            employees.Add(106, "Chowdhury");

            //Remove element
            employees.Remove(103);

            //foreach
            foreach (KeyValuePair<int,string> item in employees)
            {
                Console.WriteLine(item.Key +","+item.Value);
            }

            //get value based on key
            string eName = employees[105];
            Console.WriteLine("\nEmployee name at 105: " + eName);

            //search for specific key
            bool k = employees.ContainsKey(105);
            Console.WriteLine("\n105 exists: " + k);  
            
            //search for specific value
            bool v = employees.ContainsValue("Khalid");
            Console.WriteLine("\nKhalid exists: " + v);

            //indexof specific key
            int key = employees.IndexOfKey(105);
            Console.WriteLine("\nIndex of 105 : " + key);

            //Keys
            Console.WriteLine("\nKeys:");
            foreach (int item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("\nValues:");
            foreach (string item in employees.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
