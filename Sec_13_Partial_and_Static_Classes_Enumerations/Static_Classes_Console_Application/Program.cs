using System;

class Program
{
    static void Main()
    {
        //create object of static class
        //Country country = new Country(); // error because static class

        //access static fields
        System.Console.WriteLine(Country.CountryName);
        System.Console.WriteLine(Country.NoOfStates);
        System.Console.WriteLine(Country.GetNoOfUnionTerritories());

        Console.ReadKey();
    }
}