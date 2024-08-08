using System;
using System.Threading;

namespace Mutiple_Thread
{
    class NumbersCounter
    {
        public  void CountUp()
        {
            // i = 1 to 100
            //assume it is a large amount of code that takes few seconds to execute
            //because the threading is mainly made for CPU intensive tasks such as large amount of code or any other code that takes more time. 
            for (int i = 1; i <= 100; i++)
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"i = {i}, ");
            }
        }

        public  void CountDown()
        {
            // i = 100 to 1
            //assume it is a large amount of code that takes few seconds to execute
            //because the threading is mainly made for CPU intensive tasks such as large amount of code or any other code that takes more time. 
            for (int j = 100; j >= 1; j--)
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"j = {j}");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            //Get main Thread
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);

            //Object of NumbersCounter
            NumbersCounter numbersCounter = new NumbersCounter();
           
            //Create first thread
            ThreadStart threadStart1 = new ThreadStart(numbersCounter.CountUp);
            Thread thread1 = new Thread(threadStart1);
            thread1.Name = "Count-Up Thread";
            Console.WriteLine($"${thread1.Name} is {thread1.ThreadState.ToString()}"); //Unstarted

            thread1.Start();
            Console.WriteLine($"${thread1.Name} is ${thread1.ThreadState.ToString()}"); // Running


            //Create second thread
            ThreadStart threadStart2 = new ThreadStart(numbersCounter.CountDown);
            Thread thread2 = new Thread(threadStart2);
            thread2.Name = "Count-Down Thread";
            Console.WriteLine($"${thread2.Name}  is {thread2.ThreadState.ToString()}"); //Unstarted

            thread2.Start();
            Console.WriteLine($"${thread2.Name} is ${thread2.ThreadState.ToString()}"); // Running


            Console.WriteLine(mainThread.Name + " completed");

            Console.ReadKey();
        }
    }
}
