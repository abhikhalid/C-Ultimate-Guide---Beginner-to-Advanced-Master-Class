namespace records_example
{
    public record Person(string Name, int Age, Address PersonAddress)
    {
       public int Age {  get; set; }
    }
    
    public record Address(string city, string Country);

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", 20, new Address("London","UK"));
            person1.Age = 20;
            //Person person2 = person1; //reference copy
            Person person2 = person1 with { }; //shallow copy
            person2.Age = 30;

            Console.WriteLine($"{person1.Name},{person1.Age},{person1.PersonAddress.city}");
            Console.WriteLine($"{person2.Name},{person2.Age},{person2.PersonAddress.city}");

            Console.ReadKey();
        }
    }
}