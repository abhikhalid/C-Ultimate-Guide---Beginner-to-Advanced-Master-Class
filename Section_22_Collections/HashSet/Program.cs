using System;
using System.Collections.Generic;
namespace HashSet
{
    class Program
    {
        static void Main()
        {
            //create object of HashSet

            //here inserting is not done in insertion order
            //ex: Have a good day
            // this above string might be stored at index 0 behind the scene.
            HashSet<string> messages = new HashSet<string>()
            {
                "Good Morning", "How are you", "Have a good day"
            };

            //Add
            messages.Add("Good Luck");

            //Remove
            messages.Remove("Have a good day");

            //Remove
            messages.RemoveWhere(m => m.EndsWith("you"));

            //Search
            bool b = messages.Contains("Good Morning");
            Console.WriteLine(b);

            //Count
            Console.WriteLine("Count: "+messages.Count);

            //foreach
            //while retrieving, we get all the value in insertion order !!!
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }


            //Create Two HashSets
            HashSet<string> employees2021 = new HashSet<string>() { "Amar", "Akhil", "Sameer" };
            HashSet<string> newEmployee2022 = new HashSet<string>() { "John", "Scoot", "Smith","David"};

            //Union
            employees2021.UnionWith(newEmployee2022);

            foreach(string item in employees2021)
            {
                Console.WriteLine(item);
            }  
            
            

            //InterSect
            HashSet<string> employees2023 = new HashSet<string>() { "Amar", "Akhil", "Sameer" };
            HashSet<string> newEmployee2024 = new HashSet<string>() { "John", "Scoot", "Smith","David"};

            //Union
            employees2023.IntersectWith(newEmployee2024);

            foreach(string item in employees2023)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
