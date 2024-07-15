using IDisposable_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposable_Console
{
    internal class Program
    {
        static void DoWork()
        {
            //create object using "using declaration"
            using Sample s = new Sample();
            s.DisplayDataFromDatabase();
        } // Dispose gets called here

        static void Main(string[] args)
        {
            DoWork();

            Console.WriteLine("Some other work");
            Console.ReadKey();
        }
    }
}
