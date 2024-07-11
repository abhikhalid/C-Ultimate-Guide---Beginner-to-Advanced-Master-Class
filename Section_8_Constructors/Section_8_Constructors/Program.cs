public class Program
{
    static void Main()
    {
        //create three objects for Employee
        Employee emp1 = new Employee();
        emp1.EmpID = 101;
        emp1.Tax = 50; // using write-only property
        Employee emp2 = new Employee(101, "Scott", "Manager");
        Employee emp3 = new Employee(102, "Khalid", "Software Engineer");

        Employee emp4 = new Employee()
        {
            EmpName = "Israr",
            Job = "software enginner"
        };

        //Display Fields
        System.Console.WriteLine(Employee.CompanyName);
        System.Console.WriteLine("\nFirst Employee");
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Job);
        System.Console.WriteLine(emp1.Salary);
        System.Console.WriteLine(emp1.CalculateNetTax());
        System.Console.WriteLine();

        System.Console.WriteLine("Second Employee");
        System.Console.WriteLine(emp2.EmpID);
        System.Console.WriteLine(emp2.EmpName);
        System.Console.WriteLine(emp2.Job);
        System.Console.WriteLine(emp2.Salary);
        System.Console.WriteLine();

        System.Console.WriteLine("Third Employee");
        System.Console.WriteLine(emp3.EmpID);
        System.Console.WriteLine(emp3.EmpName);
        System.Console.WriteLine(emp3.Job);
        System.Console.WriteLine(emp3.Salary);
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}