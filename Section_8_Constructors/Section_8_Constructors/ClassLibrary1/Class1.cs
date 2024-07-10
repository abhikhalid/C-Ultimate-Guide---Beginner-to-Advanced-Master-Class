public class Employee
{
    //fields
    private int _empID;
    private string _empName;
    private string _job;

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
    }

    public Employee(int empID, string empName, string job) //parameterized constructor
    {
        this._empID = empID;
        this._empName = empName;
        this._job = job;
    }

    public Employee(int empID, string empName) //parameterized constructor
    {
        this._empID = empID;
        this._empName = empName;
    }

    // static constructor is public by default. 
    // It can not have any parameters.
    static Employee()
    {
        _companyName = "BJIT LTD.";
    }
}
