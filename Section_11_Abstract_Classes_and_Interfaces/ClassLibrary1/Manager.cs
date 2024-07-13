public class Manager : Employee
{
    private string _departmentName;

    

    public Manager()
    {

    }

    public Manager(int empID, string empName,string location,string departmentName) : base(empID, empName, location) 
    {
        this._departmentName = departmentName;
    }

    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000; //dummy value
    }

    //method Overriding

    public override string GetHealthInsuranceAmount() // this method can't be overriden in the corresponding child classes.
    {
        return "Health Insurance premium is : 500";
    }

}


