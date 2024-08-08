using System;
using System.Threading;

namespace Single_Threaded_App
{
    class NumebersCounter
    {
        public static void CountUp()
        {
            // i = 1 to 100
            //assume it is a large amount of code that takes few seconds to execute
            //because the threading is mainly made for CPU intensive tasks such as large amount of code or any other code that takes more time. 
            for (int i = 1; i <=100; i++)
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"i = {i}, ");
            }
        }

        public static void CountDown()
        {
            // i = 100 to 1
            //assume it is a large amount of code that takes few seconds to execute
            //because the threading is mainly made for CPU intensive tasks such as large amount of code or any other code that takes more time. 
            for (int j = 100; j>= 1; j--)
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
            NumebersCounter.CountUp();
            NumebersCounter.CountDown();


            Console.WriteLine(mainThread.Name + " completed");

            Console.ReadKey();
        }
    }
}
