using System;

class Program
{
    static void Main()
    {
        //create object of Person class
        Person person = new Person();
        person.PersonName = "Khalid";
        person.Email = "khalid@gmail.com";
        person.AgeGroup = AgeGroupEnumeration.Adult;
        //person.AgeGroup = AgeGroupEnumeration.Todler; //user is not allowed to set other value
        
        Console.WriteLine(person.AgeGroup);
        Console.ReadKey();  
    }
}