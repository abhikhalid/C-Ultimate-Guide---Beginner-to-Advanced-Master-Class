namespace records_example
{
    public record Person(string Name, int Age,Address PersonAddress);
    public record Address(string city);


    class Program
    {
        static void Main()
        {
            //Person person = new Person("John",20,100); //error
            Person person1 = new Person("John", 20, new Address("Dhaka"));
            Person person2 = new("Khalid", 20,new Address("Pabna"));

            Console.WriteLine($"{person1.Name},{person1.Age},{person1.PersonAddress.city}");
            Console.WriteLine($"{person2.Name},{person2.Age},{person2.PersonAddress.city}");
            //person1.Name = 'Changed'; //Error: Init-only proeprty can only be assigned in a constructor or object initializer
            Console.ReadKey();
        }
    }
}