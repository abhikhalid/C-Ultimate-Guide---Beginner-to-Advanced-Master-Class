namespace record_structs_example
{
    //behind the scene, it is struct.
    //public readonly record struct Person(string? Name, int? Age);

    public record struct Person(string? Name, int? Age);

    class Program
    {
        static void Main()
        {
            Person person = new Person("Khalid",30);
            // ToString(), Deconstruct(), Equals()
            Console.WriteLine(person.ToString());

            Person person2 = person; //internally, it will create another structure variable. 
            person2.Age = 40; // will not affect the other struct variable 
            Console.ReadKey();
        }
    }
}