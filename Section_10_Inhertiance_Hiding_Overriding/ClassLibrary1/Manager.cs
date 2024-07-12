public class Manager : Employee
{
    private string _departmentName;

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
        return DepartmentName + "at" + base.Location;
    }
}