public sealed class Manager : Employee
{
    private string _departmentName;

    //constructor of child class
    public Manager(int empId,string empName,string location,string departmentName) : base(empId,empName,location) { 
      this._departmentName = departmentName;
    }

    //property
    public string DepartmentName
    {
        set { _departmentName = value; }
        get { return _departmentName; }
    }


    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000; //dummy value
    }

    public string GetFullDepartmentName()
    {
        return DepartmentName + " at " + base._location;
    }

    //method Overriding
    public override string GetHealthInsuranceAmount() 
    {
        System.Console.WriteLine(base.GetHealthInsuranceAmount());
        return "Health Insurance premium is : 1500";
    }
}


//erro becaue Manager is a sealed class

//public BranchManager : Manager{

//}