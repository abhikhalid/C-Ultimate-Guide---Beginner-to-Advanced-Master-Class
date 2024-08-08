using System;
using System.Threading;

namespace Mutiple_Thread
{
    class NumbersCounter
    {
        public  void CountUp(object? count)
        {
            try
            {
                Console.WriteLine("Count Up started");

                //for demonstration purpose, let's add another sleep
                Thread.Sleep(1000);

                int? countInt = (int?)count;

                for (int i = 1; i <= countInt; i++)
                {
                    System.Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"i = {i}, ");

                    Thread.Sleep(1000); // 1000 miliseconds = 1 second
                }

                Thread.Sleep(1000);
                Console.WriteLine("Count Up completed");
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine("Count-Up Thread interrupted");
            }
        }

        public  void CountDown(object? count)
        {
            Console.WriteLine("Count Down Started");
            Thread.Sleep(1000);

            int? countInt = (int?)count;

            for (int? j = countInt; j >= 1; j--)
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"j = {j}");
                Thread.Sleep(1000);
            }

            Thread.Sleep(1000);
            Console.WriteLine("Count Down completed");
        }
    }

    internal class Program
    {
        static void Main()
        {
            //Get main Thread
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name + " started");

            //Object of NumbersCounter
            NumbersCounter numbersCounter = new NumbersCounter();
           
            //Create first thread
            //ThreadStart threadStart1 = new ThreadStart(() =>
            //{
            //    numbersCounter.CountUp(100);
            //});

            ParameterizedThreadStart threadStart1 = new ParameterizedThreadStart(numbersCounter.CountUp);

          
            Thread thread1 = new Thread(threadStart1);
            thread1.Name = "Count-Up Thread";
            thread1.Priority = ThreadPriority.Highest;

            thread1.Start(100);
            Console.WriteLine($"${thread1.Name} ({thread1.ManagedThreadId}) is {thread1.ThreadState.ToString()}"); // Running


            //Create second thread
            //ThreadStart threadStart2 = new ThreadStart(numbersCounter.CountDown);
            ParameterizedThreadStart threadStart2 = new ParameterizedThreadStart(numbersCounter.CountDown);
            
            
            Thread thread2 = new Thread(threadStart2)
            {
                Name = "Count-Down Thread",
                Priority = ThreadPriority.BelowNormal
            };

            thread2.Start(100);
            Console.WriteLine($"${thread2.Name} ({thread2.ManagedThreadId}) is {thread2.ThreadState.ToString()}"); // Running


            //JOIN
            thread1.Join();
            thread2.Join();

            //Main thread now wait for thread1 and thread2 to be excuted.
            Console.WriteLine(mainThread.Name + " completed");

            Console.ReadKey();
        }
    }
}
