public class Program
{
    public static void Main()
    {
        IPerson person = new Manager();

        person.DateOfBirth = System.Convert.ToDateTime("1990-07-15");
        System.Console.WriteLine(person.GetAge());

        System.Console.ReadKey();
    }
}