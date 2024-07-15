using Delegates_Class_Library;
using System;

namespace Section_20_Delegates_and_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object of Sample class
            Sample s = new Sample();

            //create delegate object
            MyDelegateType myDelegateType;

            //add method reference to delegate
            myDelegateType = new MyDelegateType(s.Add);

            //invoke method using delegate object
            Console.WriteLine(myDelegateType.Invoke(10, 20));

            Console.ReadKey();      
        }
    }
}
