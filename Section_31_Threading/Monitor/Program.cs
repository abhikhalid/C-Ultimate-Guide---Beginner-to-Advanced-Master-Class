using System;
using System.Threading;

namespace MonitorExplain
{
    class Shared
    {
        public static int SharedResource { get; set; } = 0;
        public static readonly object lockObject = new object();
    }

    class NumbersUpCounter
    {
        public int Count { get; set; }

        public void CountUp(Action<long> callback)
        {
            long sum = 0;

            try
            {
                Console.WriteLine("Count Up started");

                //for demonstration purpose, let's add another sleep
                Thread.Sleep(1000);

                for (int i = 1; i <= Count; i++)
                {
                    sum += i;

                    // Monitor.Enter(Shared.lockObject); //wait for lock gets opened

                    lock (Shared.lockObject)
                    {
                        Console.WriteLine($"Shared Resource in Count-Up : {Shared.SharedResource}, "); //0 (Initial Value)
                        Shared.SharedResource++;
                        // Monitor.Exit(Shared.lockObject); //close the lock
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
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
            finally
            {
                callback(sum);
            }
        }
    }

    class NumbersDownCounter
    {
        public int Count { get; set; }

        public void CountDown()
        {
            Console.WriteLine("Count Down Started");
            Thread.Sleep(1000);

            for (int? j = Count; j >= 1; j--)
            {
                //Monitor.Enter(Shared.lockObject); //wait for the lock gets opened. (aquired)
                lock (Shared.lockObject)
                {
                    Console.Write($"Shared Resource in Count-Down : {Shared.SharedResource}, "); // 1 (Initial Value)

                    Shared.SharedResource--;
                }
                //Monitor.Exit(Shared.lockObject); // Close (release) the lock

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"j = {j}, ");
                Thread.Sleep(100);
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
            NumbersUpCounter numbersUpCounter = new NumbersUpCounter()
            {
                Count = 100
            };

            //Create first thread
            //ThreadStart threadStart1 = new ThreadStart(() =>
            //{
            //    numbersCounter.CountUp(100);
            //});

            //ParameterizedThreadStart threadStart1 = new ParameterizedThreadStart(numbersCounter.CountUp);

            //Create Callback method
            //I am using action here because this callback doesn't return anything it will receive the return value from the thread method
            Action<long> callback = sum =>
            {
                Console.WriteLine($"\nReturn value from Count-Up Thread is : {sum}");
            };


            ThreadStart threadStart1 = new ThreadStart(() =>
            {
                numbersUpCounter.CountUp(callback);
            });

            Thread thread1 = new Thread(threadStart1);
            thread1.Name = "Count-Up Thread";
            thread1.Priority = ThreadPriority.Highest;

            //MaxCount maxCount1 = new MaxCount() { Count = 100};

            //Create callback method

            thread1.Start();
            Console.WriteLine($"${thread1.Name} ({thread1.ManagedThreadId}) is {thread1.ThreadState.ToString()}"); // Running


            //Create second thread
            //ThreadStart threadStart2 = new ThreadStart(numbersCounter.CountDown);
            // ParameterizedThreadStart threadStart2 = new ParameterizedThreadStart(numbersCounter.CountDown);

            NumbersDownCounter numbersDownCounter = new NumbersDownCounter() { Count = 100 };

            ThreadStart threadStart2 = new ThreadStart(numbersDownCounter.CountDown);



            Thread thread2 = new Thread(threadStart2)
            {
                Name = "Count-Down Thread",
                Priority = ThreadPriority.BelowNormal
            };

            // MaxCount maxCount2 = new MaxCount() { Count = 100 };

            //thread2.Start(maxCount2);
            thread2.Start();

            Console.WriteLine($"${thread2.Name} ({thread2.ManagedThreadId}) is {thread2.ThreadState.ToString()}"); // Running


            //JOIN
            thread1.Join();
            thread2.Join();

            Console.WriteLine($"\nShared Resource : ${Shared.SharedResource}"); // Expected: 0

            //Main thread now wait for thread1 and thread2 to be excuted.
            Console.WriteLine(mainThread.Name + " completed");

            Console.ReadKey();
        }
    }
}
