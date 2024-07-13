public class Manager : IEmployee
{
    private string _departmentName;
    private int _empID;
    private string _empName;
    private string _location;

    //properties


    //property
    public string DepartmentName
    {
        set { _departmentName = value; }
        get { return _departmentName; }
    }

    public int EmpID 
    {
        get {  return _empID; }
        set { this._empID = value; }
    }

    public string EmpName 
    {
        get { return _empName; }
        set { this._empName = value; }
    }

    public string Location 
    {
        get { return _location; }
        set { this._location = value; }
    }


    //method Overriding
    // you should not say override here
    //whereas you must use the override keyword while implementation of abstract method of abstract class.
    public string GetHealthInsuranceAmount() // this method can't be overriden in the corresponding child classes.
    {
        return "Health Insurance premium is : 1500";
    }


    public Manager()
    {

    }

    public Manager(int empID, string empName,string location,string departmentName)
    {
        this._empID = empID;
        this._empName= empName;
        this._location = location;
        this._departmentName = departmentName;
    }

    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000; //dummy value
    }
}


