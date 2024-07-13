public class SalesMan : IEmployee
{
    private string _region;
    private int _empID;
    private string _empName;
    private string _location;

    //properties
    public int EmpID
    {
        get { return _empID; }
        set { 
            // this is the real benefit of interface
        
            if(value>=10000 && value <= 2000)
            {
                this._empID = value;
            }

        }
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


    public SalesMan()
    {

    }

    public SalesMan(int empID,string empName,string location,string region)
    {
        this._empID=empID;
        this._empName=empName;
        this._location=location;
        this._region=region;
    }

    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000; //dummy value
    }
}