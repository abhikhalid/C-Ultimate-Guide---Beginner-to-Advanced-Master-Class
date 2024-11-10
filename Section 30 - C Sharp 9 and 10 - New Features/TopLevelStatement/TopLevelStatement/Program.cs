// we can also import namespaces
using System;
using System.IO;


//but can we write like this? 

/// no , because the top level statment must be present at the top of the file. (not after the namespaces or classes)
/// /*
//namespace namespace1
//{
//    class Sample
//    {

//    }
//}

//now my, second question is, can we write top-level statment in mutiple file of the same project? 
// ans is no!!! because only one compilation unit can have top-level statements.

Console.WriteLine("Hello, World!");

string name = "Khalid";
Console.WriteLine($"Hello to {name}");
Console.ReadKey();

