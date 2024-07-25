using System;
using System.Collections.Generic;

namespace Dictionary
{
     class Program
    {
        static void Main()
        {
            //create empty dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                {101,"Khalid"},
                {102,"Mahmud"},
                {103,"Khan"},
            };

            //foreach loop for dictionary
            foreach (KeyValuePair<int,string> item in employees)
            {
                Console.WriteLine(item.Key+", "+item.Value);
            }

            //get value based on the key
            string s = employees[101];
            Console.WriteLine("\nValue at 101: "+s);

           
            //Keys
            Dictionary<int,string>.KeyCollection keys = employees.Keys;

            Console.WriteLine("\nKeys:");

            foreach (int item in keys)
            {
                Console.WriteLine(item);              
            }

            //Duplicate key exception
            //employees.Add(101);


            //Remove
            employees.Remove(102);

            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }


            //ContainsKey
            bool a = employees.ContainsKey(101);
            Console.WriteLine("Containskey:"+a);

            //ContainsValue
            bool b = employees.ContainsValue("Khalid");
            Console.WriteLine("Contains Value: " + b);

            //Clear
            employees.Clear();


            Console.ReadKey();
        }
    }
}
