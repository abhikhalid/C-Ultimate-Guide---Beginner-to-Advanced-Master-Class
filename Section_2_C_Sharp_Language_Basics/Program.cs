using System;

class Sample
{
    static void Main()
    {
        System.Console.WriteLine("USA");
        System.Console.WriteLine("UK");
        System.Console.WriteLine("India");
        goto mylabel;
        System.Console.WriteLine("France");
        System.Console.WriteLine("Italy");
        System.Console.WriteLine("Iran");
        mylabel:
        System.Console.WriteLine("Nepal");
        System.Console.WriteLine("Dubai");
       
        System.Console.ReadKey();
    }
}