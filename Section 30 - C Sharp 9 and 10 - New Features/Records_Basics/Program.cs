namespace records_example
{
    public record Person(string Name, int Age, Address PersonAddress);

    public record Address(string city, string Country);

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", 20, new Address("London","UK"));
            Person person2 = new Person("John", 20, new Address("London", "UK"));

            Console.WriteLine(person1.Equals(person2)); //in case of class, you would have got false. 
            Console.WriteLine(person1 == person2); // True 
            Console.WriteLine(person2 != person1);// False

            Console.ReadKey();
        }
    }
}