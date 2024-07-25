using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HashTableExample
{
    class Program
    {
        static void Main()
        {
            //create a hashtable
            Hashtable employees = new Hashtable()
            {
                {101,"Khalid"},
                {102,"Mahmud"},
                {103,"Khan"},
                {104,"Abhi"},
                {105,"Israr"},
                {"hello",10.934}
            };

            //Add element
            employees.Add(106, "Chowdhury");

            //Remove element
            employees.Remove(103);

            //foreach
            foreach (DictionaryEntry item in employees) //we can also use 'var' keyword
            {
               Console.WriteLine(item.Key +"," + item.Value);
            }

            //get value based on key

            //this is a drawback of hastable over the dictionary and sorted list
            if(employees[105] is string)
            {
                string value = Convert.ToString(employees[105]);
                Console.WriteLine(value);
            }

            if (employees[105] is double)
            {
                double value = Convert.ToDouble(employees[105]);
                Console.WriteLine(value);
            }

            //search for specific key
            bool k = employees.ContainsKey(105);
            Console.WriteLine("\n105 exists: " + k);

            //search for specific value
            bool v = employees.ContainsValue("Khalid");
            Console.WriteLine("\nKhalid exists: " + v);

           

            //Keys
            Console.WriteLine("\nKeys:");
            foreach (var item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("\nValues:");
            foreach (var item in employees.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
