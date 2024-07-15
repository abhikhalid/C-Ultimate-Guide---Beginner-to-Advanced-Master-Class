using GC_Destructor_IDisposable_Class_Library;
using System;
namespace Section_19_GC_Destructors_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object of Sample class
            Sample sample = new Sample();
            Console.ReadKey();
        }
        //destructor gets called automatically.
    }
}
