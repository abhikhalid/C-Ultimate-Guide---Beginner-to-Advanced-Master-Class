using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposable_Class_Library
{
    public class Sample : IDisposable
    {
        //constructor
        public Sample() {
            Console.WriteLine("Database connected.");
        }

        //method
        public void DisplayDataFromDatabase()
        {
            Console.WriteLine("Reading data from database");
        }

        //Dispose
        //Generally, it is recommended to place the database connection and file connection closing logic in the Dispose Method.
        public void Dispose()
        {
            Console.WriteLine("Database disconnected");
        }
    }
}
