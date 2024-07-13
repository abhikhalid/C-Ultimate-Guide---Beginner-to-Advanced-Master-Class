public class SalesMan : Employee
{
    private string _region;

    public SalesMan()
    {

    }

    public SalesMan(int empID,string empName,string location,string region) : base(empID,empName,location)
    {
        this._region = region;
    }

    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000; //dummy value
    }


    //method Overriding
    public override string GetHealthInsuranceAmount()
    {
        return "Health Insurance premium is : 1500";
    }
}