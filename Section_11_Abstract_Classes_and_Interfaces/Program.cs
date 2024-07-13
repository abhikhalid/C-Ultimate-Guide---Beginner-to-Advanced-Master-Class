public class Program
{
    public static void Main()
    {
        // error, abstract class can not be instantiated. 
        //Employee employee = new Employee(); 

        Employee emp= new Manager();
      
        System.Console.WriteLine(emp.GetHealthInsuranceAmount());

        emp = new SalesMan();

        System.Console.WriteLine(emp.GetHealthInsuranceAmount());

        System.Console.ReadKey();

    }
}