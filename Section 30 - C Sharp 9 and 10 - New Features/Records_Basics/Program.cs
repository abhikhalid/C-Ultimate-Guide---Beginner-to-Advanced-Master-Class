public record Person(string Name, int Age);


class Program
{
    static void Main()
    {
        //Person person = new Person("John",20,100); //error
        Person person1 = new Person("John",20);
        Person person2 = new("John", 20);

        Console.WriteLine($"{person1.Name},{person1.Age}");
        Console.WriteLine($"{person2.Name},{person2.Age}");
        //person1.Name = 'Changed'; //Error: Init-only proeprty can only be assigned in a constructor or object initializer
        Console.ReadKey();
    }
}