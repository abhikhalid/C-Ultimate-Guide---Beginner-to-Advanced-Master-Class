using System;

namespace Anonymous_Arrays
{
    internal class Program
    {
        static void Main()
        {
            //create anonymous array/ implicitly typed array
            var persons = new[]
            {
                new {PersonName = "Khalid", Email="khalid@gmail.com"},
                new {PersonName = "Mahmud", Email="khalid@gmail.com"},
                new {PersonName = "Khan", Email="khalid@gmail.com"},
                new {PersonName = "Israr", Email="khalid@gmail.com"},
            };

            //foreach
            foreach (var item in persons)
            {
                Console.Write(item.PersonName);
                Console.Write(",");
                Console.WriteLine(item.Email);
            }

            Console.ReadKey();
        }
    }
}
