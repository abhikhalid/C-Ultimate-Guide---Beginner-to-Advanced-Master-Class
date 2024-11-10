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
}

class EmployeeBusinessLogic
{
    public Employee? GetEmployee()
    {
        //return null;
        return new Employee();
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

        //Console.WriteLine(employee.x);
        Console.ReadKey();
    }
}

//Employee  = Non-nullable (null values are not accepted!)
//Employee? = Nullable (accepts null value)