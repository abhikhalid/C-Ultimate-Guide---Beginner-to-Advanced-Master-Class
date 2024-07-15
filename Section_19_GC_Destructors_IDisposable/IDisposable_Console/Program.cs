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
        static void Main(string[] args)
        {
            //create object
            // The using block ensures that the Dispose method called at the end of the 'using' block.
            using (Sample s = new Sample())
            {
                s.DisplayDataFromDatabase();
            }

            Console.WriteLine("Some other work");
            Console.ReadKey();
        }
    }
}
