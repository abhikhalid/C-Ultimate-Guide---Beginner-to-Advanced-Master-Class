class Employee
{
    //public string FirstName { get; set; } = string.Empty;
    //public string LastName { get; set; } = string.Empty;
    
    //these are non nullable types
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public AddressDetails? PersonAddressDetails { get; set; }

    public Employee()
    {
        FirstName = "default string";
        LastName = "default string";
    }

    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class EmployeeBusinessLogic
{
    public Employee? GetEmployee()
    {
        //return null;
        //return new Employee();
        //return new();
        //return new("Khalid","Mahmud");
        //Employee e = new Employee("Khalid","Mahmud");

        // not possible
        //var e = new("Khalid", "Mahmud");
        //dynamic e = new("Khalid", "Mahmud");

        Employee e = new Employee("Khalid", "Mahmud");
        return e;
    }
}

class DataPrinter
{
    public static void PrintEmployee(Employee e)
    {
        if (e != null)
        {
            Console.WriteLine($"{e.FirstName} {e.LastName}");
        }
    }
}

class AddressDetails
{
    //these are nullable types
    public string? City { get; set; }
    public int? ZipCode { get; set; }
}

class Program
{
    static void Main()
    {
        EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
        Employee? employee = employeeBusinessLogic.GetEmployee();

        bool isValid = employee == null;

        if(isValid)
        {
            Console.WriteLine("The variable is null");
        }
        else
        {
            Console.WriteLine(employee!.FirstName.ToUpper()); //Null-Forgiving Operator
            Console.WriteLine(employee!.LastName.ToLower());

            //if(employee!.PersonAddressDetails != null)
            //{
            //    Console.WriteLine(employee.PersonAddressDetails.City);
            //    Console.WriteLine(employee.PersonAddressDetails.ZipCode);
            //}
            Console.WriteLine(employee.PersonAddressDetails?.City);
            Console.WriteLine(employee.PersonAddressDetails?.ZipCode);
        }

        DataPrinter.PrintEmployee(new ("one","two"));
        //Console.WriteLine(employee.x);
        Console.ReadKey();
    }
}

//Employee  = Non-nullable (null values are not accepted!)
//Employee? = Nullable (accepts null value)