using System;
using System.Collections.Generic;
using System.Threading;

namespace Wait_and_Pulse
{
    static class Shared
    {
        //Lock object to be used by both Producer and Consumer
        public static object LockObject = new object();

        //Buffer to store int data values
        public static Queue<int> Buffer = new Queue<int>();
        
        //maximum capacity of the buffer (queue)
        public const int BufferCapacity = 5;

        public static void Print()
        {
            //O/P: Buffer: 1,2,3,4,5
            Console.WriteLine("Buffer: ");
            foreach (int item in Buffer)
            {
                Console.WriteLine($"{item}, ");
            }
            Console.WriteLine();
        }
    }

    class Producer
    {
        //Thread Method
        public void Produce()
        {
            Console.WriteLine($"Producer: Generating Data");
            //actual Code goes on
            for(int i = 1; i <= 10; i++)
            {
                lock(Shared.LockObject)  // lock, added later for demostration purposes.
                 {
                    Console.WriteLine("Producer: Generating data");
                    Thread.Sleep(7000); // 7 sec. artificial delay

                    //Buffer is Full
                    if (Shared.Buffer.Count == Shared.BufferCapacity)
                    {
                        Console.WriteLine("Buffer is full. Waiting for signal from consumer.");
                        Monitor.Wait(Shared.LockObject); // Wait for signal from consumer thread. 
                    }

                    Shared.Buffer.Enqueue(i);

                    Console.WriteLine($"Producer produced: {i}");

                    Shared.Print();

                    //Wake-up Consumer Thread
                    Monitor.Pulse(Shared.LockObject); //notify the cosumer that one value has been added to the buffer.
                }
            }
          

            Console.WriteLine("Production Completed");
        }
    }

    class Consumer
    {
        //Thread Method
        public void Consume()
        {
            Console.WriteLine($"Consumer: Consumer Started");
            //actual Code goes on

            for(int i = 0; i <10; i++) // pore add koresi explaination er purpose e.
            {
                //as we are going to accss the shared resource, for thread synchronization, we will use lock statment
                lock (Shared.LockObject)
                {
                    if (Shared.Buffer.Count == 0)
                    {
                        Console.WriteLine("Buffer is empty. Waiting for signal from producer.");
                        Monitor.Wait(Shared.LockObject); 
                    }
                }

                Console.WriteLine("Consumer Started");

                Thread.Sleep(2500); //artificial lateny, assuming the time taken for reading the data.

                //we could have use one lock statment here
                lock (Shared.LockObject)
                {
                    int val = Shared.Buffer.Dequeue();
                    Console.WriteLine($"Consumer consumed: {val}");

                    //Signal the producer that there is a space in the buffer
                    Monitor.Pulse(Shared.LockObject);
                }
            }
            
            Console.WriteLine("Consumption Completed");
        }
    }

    class Program
    {
        static void Main()
        {
            //create objects of Producer and Consumer types
            Producer producer = new Producer();
            Consumer consumer = new Consumer();

            //create objects of Thread class

            //internally creates object of ThreadStart
            Thread producerThread = new Thread(producer.Produce)
            {
                Name = "Producer Thread"
            };
            Thread consumerThread = new Thread(consumer.Consume)
            {
                Name = "Consumer Thread"
            };

            //Start thread
            producerThread.Start();
            consumerThread.Start();

            //Join (main thread will wait for the following thread)
            producerThread.Join();
            consumerThread.Join();

            Console.ReadKey();
        }
    }
}
