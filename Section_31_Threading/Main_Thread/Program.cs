using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Main_Thread
{
    internal class Program
    {
        static void Main()
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Console.WriteLine(mainThread);
            Console.WriteLine(mainThread.Name);

            Method1();

            Console.ReadKey();
        }

        static void Method1()
        {
            Console.WriteLine("Method 1");
        }
    }
}
