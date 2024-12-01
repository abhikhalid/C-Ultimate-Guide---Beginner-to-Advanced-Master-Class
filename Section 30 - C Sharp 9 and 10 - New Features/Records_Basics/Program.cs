namespace records_example
{
    public record Person(string Name, int Age, Address PersonAddress);
    
    public record Address(string city, string Country);

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", 20, new Address("London","UK"));

            //var (name, _, (city,Country)) = person1;
            var (name, age, (city,Country)) = person1;
            

            Console.WriteLine($"{name},{age},{city},{Country}");

            Console.ReadKey();
        }
    }
}