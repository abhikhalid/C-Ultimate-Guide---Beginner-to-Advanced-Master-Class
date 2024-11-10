class Employee
{
    public int x { get; set; }
}

class EmployeeBusinessLogic
{
    public Employee? GetEmployee()
    {
        return null;
    }
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
            Console.WriteLine(employee!.x); //Null-Forgiving Operator
        }

        //Console.WriteLine(employee.x);
        Console.ReadKey();
    }
}

//Employee  = Non-nullable (null values are not accepted!)
//Employee? = Nullable (accepts null value)