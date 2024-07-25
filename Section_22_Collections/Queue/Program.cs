using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of Queue class
            Queue<string> queue = new Queue<string>();

            //Enqueue
            queue.Enqueue("Task 3");
            queue.Enqueue("Task 5");
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 4");
            queue.Enqueue("Task 2");


            //foreach
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            string dq = queue.Dequeue();
            Console.WriteLine("Dequeue:" + dq);

            //Peek 
            string pk = queue.Peek();
            Console.WriteLine("Peek : " + pk);

            Console.ReadKey();
        }
    }
}
