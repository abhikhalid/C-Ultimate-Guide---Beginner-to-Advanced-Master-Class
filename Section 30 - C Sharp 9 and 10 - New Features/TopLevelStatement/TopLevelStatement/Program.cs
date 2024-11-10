// we can also import namespaces
using System;
using System.IO;




Console.WriteLine("Hello, World!");

string name = "Khalid";
Console.WriteLine($"Hello to {name}");
Console.ReadKey();


//next question, can we write like this? 
// NO! The variables or local functions that are created inside of your top level statements are not accessible to other classes or other namespaces.
// It is because this particular top level statement that you write here will be eventually converted as static void main by the compiler itself.

//namespace namespace1
//{
//    class Sample
//    {
//        string str = name; 
//    }
//}