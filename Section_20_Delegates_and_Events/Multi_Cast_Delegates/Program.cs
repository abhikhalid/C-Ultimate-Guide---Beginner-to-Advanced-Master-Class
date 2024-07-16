using Multi_Cast_Delegate_ClassLibrary;
using System;
namespace Multi_Cast_Delegates
{
    class Program
    {
        static void Main()
        {
            //create object of Sample
            Sample sample = new Sample();

            //create reference variable of MyDelegateType
            MyDelegateType myDelegateType;
            //add ref of first target method
            myDelegateType = sample.Add;
            //add ref of second target method
            myDelegateType += sample.Multiply;

            //invoke both target methods; first Add method, and the Multiply Method
            myDelegateType.Invoke(40, 10);

            Console.ReadKey();
        }
    }
}
