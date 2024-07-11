public class Employee
{
    //fields
    private int _empID;
    private string _empName;
    private string _job;
    private double _salary;
    private double _tax;

    private static string _companyName;

    public int EmpID
    {
        set 
        { 
           if(value >= 100)
            {
                _empID = value;
            }
        }
        get { return _empID; }
    }

    public string EmpName
    {
        set { _empName = value; }
        get { return _empName; }
    }

    public string Job
    {
        set { _job = value; }
        get { return _job; }
    }
    public static string CompanyName
    {
        set
        {
            if (value.Length <= 20)
            {
                _companyName = value;
            }
        }
        get { return _companyName; }
    }

    //constructor
    public Employee() // default/ parameter-less constructor
    {
        _empID = 101;
        _empName = "No name";
        _job = "some job title";
        this._salary = 1000;
    }

    public Employee(int empID, string empName, string job) //parameterized constructor
    {
        this._empID = empID;
        this._empName = empName;
        this._job = job;
        this._salary = 1000;
    }

    public Employee(int empID, string empName) //parameterized constructor
    {
        this._empID = empID;
        this._empName = empName;
        this._salary = 1000;
    }

    // static constructor is public by default. 
    // It can not have any parameters.
    static Employee()
    {
        _companyName = "BJIT LTD.";
    }

    //readonly property
    public double Salary
    {
        get
        {
            return _salary;
        }
    }

    //write only property
    public double Tax
    {
        set
        {
            if(value >=0 && value <= 100)
            {
                _tax = value;
            }
        }
    }

    public double CalculateNetTax()
    {
        return Salary - _tax;
    }

    // Automatic Properties
    //public string NativePlace { internal get;set; }
    //public string NativePlace { get;set; }


    public string NativePlace { get; set; } = "Dhaka";
}
