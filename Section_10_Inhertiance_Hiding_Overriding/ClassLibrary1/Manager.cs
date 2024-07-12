public class Manager : Employee
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

    //method hiding
    public new string GetHealthInsuranceAmount() //without the new keyword also, the method hiding is done. by writing new keword, we are saying to compiler that, we are hiding the parent class's method intentionally.
    {
        return "Health Insurance premium is : 1500";
    }
}