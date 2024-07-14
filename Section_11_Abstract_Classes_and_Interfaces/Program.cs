public class Program
{
    public static void Main()
    {
        IPerson person = new Manager();
        person.GetAge(); 

        IEmployee employee = new Manager();
        employee.GetAge();

        System.Console.ReadKey();
    }
}