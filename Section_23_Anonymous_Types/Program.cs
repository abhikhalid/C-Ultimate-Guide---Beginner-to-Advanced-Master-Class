using ClassLibrary1;
using System;

namespace Section_23_Anonymous_Types
{
    internal class Program
    {
        static void Main()
        {
            //create object of Person class
            Person p = new Person();

            p.GetPersonName();
            p.GetPersonAge();


            // automatically C# compiler creates a random class and in that class it has two properties.
            // the developer need not worry and create such class.
            var person = new
            {
                PersonName = p.GetPersonName(),
                Age = p.GetPersonAge(),
                Address = new {Street = "abc", City = "xyz"}
            };

            //Print
            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address.City);
            Console.WriteLine(person.Address.Street);

            Console.ReadKey();

        }
    }
}
