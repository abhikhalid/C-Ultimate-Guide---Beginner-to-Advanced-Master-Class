class Program
{
    public static void Main()
    {
        Employee emp1 = new Employee(101, "Khalid", "Dhaka");
        //emp1.EmpID = 101;
        //emp1.EmpName = "Khalid";
        //emp1.Location = "Dhaka";

        System.Console.WriteLine("Object of Parent Class (Employee):");
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Location);
        System.Console.WriteLine();

        //create object of Manager
        Manager mgr1 = new Manager(101, "Mahmud", "London", "Finance");
        //mgr1.EmpID = 101;
        //mgr1.EmpName = "Mahmud";
        //mgr1.Location = "London";
        //mgr1.DepartmentName = "Finance";

        System.Console.WriteLine("Object of Parent Class (Manager):");
        System.Console.WriteLine(mgr1.EmpID);
        System.Console.WriteLine(mgr1.EmpName);
        System.Console.WriteLine(mgr1.Location);
        System.Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
        System.Console.WriteLine(mgr1.GetFullDepartmentName());
        //method hiding
        System.Console.WriteLine(mgr1.GetHealthInsuranceAmount()); 
        System.Console.WriteLine();

        //create object of SalesMan
        SalesMan salesMan1 = new SalesMan(101,"Isar", "New York", "Accounting");
        //salesMan1.EmpID = 101;
        //salesMan1.EmpName = "Isar";
        //salesMan1.Location = "New York";
        //salesMan1.Region = "Accounting";

        System.Console.WriteLine("Object of Parent Class (SalesMan):");
        System.Console.WriteLine(salesMan1.EmpID);
        System.Console.WriteLine(salesMan1.EmpName);
        System.Console.WriteLine(salesMan1.Location);
        System.Console.WriteLine(salesMan1.GetSalesOfTheCurrentMonth());
        System.Console.WriteLine();

        System.Console.ReadKey();

    }
}