using System;
using ClassLibrary1;
using Section_18_Extension_Methods_and_Pattern_Matching;

class Program
{
    static void Main()
    {
        //create object
        Product p = new Product() { ProductCost = 1000, DiscountPercentage =10  };
        
        //call the extension method
        Console.WriteLine(p.GetDiscount());
        Console.ReadKey();
    }
}