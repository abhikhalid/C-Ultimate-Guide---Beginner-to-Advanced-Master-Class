namespace records_example
{
    //by default records are immutable.
    public record Person(string Name, int Age, Address PersonAddress)
    {
        //but, in this way you can add mutable properties.
        public int x { get; set; }
    }

    // Whenever you would like to create fully immutable properties records are best or 
    // you want all immutable properties with just one or two mutable properties for some reason then also records are best!

    public record Address(string city)
    {
        public string? Country { get; set;}
    }


    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", 20, new Address("Dhaka"));
            Person person2 = new("Khalid", 20,new Address("Pabna"));
            person2.PersonAddress.Country = "Bangladesh"; //setting mutable property. 

            Console.WriteLine($"{person1.Name},{person1.Age},{person1.PersonAddress.city}");
            Console.WriteLine($"{person2.Name},{person2.Age},{person2.PersonAddress.city}");
            //person1.Name = 'Changed'; //Error: Init-only proeprty can only be assigned in a constructor or object initializer
            Console.ReadKey();
        }
    }
}