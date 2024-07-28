using Implicitly_Class_Library.namespace2.namespace3;
using System;

class Program
{
    static void Main()
    {
       var p = new Person() { PersonName = "Harsha" };
       var p2 = "Khalid".ToUpper();

       Console.WriteLine(p.PersonName);
       Console.WriteLine(p2);
       Console.ReadKey();
    }
}