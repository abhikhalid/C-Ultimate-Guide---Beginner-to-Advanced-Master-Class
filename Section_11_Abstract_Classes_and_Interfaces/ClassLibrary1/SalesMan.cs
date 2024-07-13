public class SalesMan : IEmployee
{
    private string _region;

    public int EmpID { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public string EmpName { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public string Location { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

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
    public  string GetHealthInsuranceAmount()
    {
        return "Health Insurance premium is : 1500";
    }
}