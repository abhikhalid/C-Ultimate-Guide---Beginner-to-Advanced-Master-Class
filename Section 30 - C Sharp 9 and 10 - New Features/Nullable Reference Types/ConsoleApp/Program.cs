class Employee
{
    public int x { get; set; }
}

class EmployeeBusinessLogic
{
    public Employee? GetEmployee()
    {
        //return new Employee()
        //{
        //    x = 10
        //};

        return null;
    }
}

class Program
{
    static void Main()
    {
        EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
        Employee? employee = employeeBusinessLogic.GetEmployee();

        if(employee != null)
        {
            Console.WriteLine(employee.x);
        }

        //Console.WriteLine(employee.x);
        Console.ReadKey();
    }
}

//Employee  = Non-nullable (null values are not accepted!)
//Employee? = Nullable (accepts null value)