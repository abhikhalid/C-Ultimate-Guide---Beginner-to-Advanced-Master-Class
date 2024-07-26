using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable
{
    internal class Program
    {
        static void Main()
        {
            //create a collectino
            IEnumerable<string> messages;
            messages = new List<string>()
            {
                "How are you",
                "Have a great day",
                "Thanks for the meeting"
            };

            //foreach
            //Console.WriteLine("IEnumerable");

            //foreach (var message in messages) {
                
            //    Console.WriteLine(message);

            //}

            //Let's see how foreach works behind the scene
            Console.WriteLine("\nIEnumerator");
            IEnumerator<string> enumerator = messages.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext()) { 
              Console.WriteLine(enumerator.Current);
            }

            Console.ReadKey();
        }
    }
}
