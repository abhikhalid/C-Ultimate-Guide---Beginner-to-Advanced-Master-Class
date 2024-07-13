using System;

public class Manager : IEmployee, IPerson
{
    private string _departmentName;
    private System.DateTime _dateOfBirth;

    public int EmpID { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public string EmpName { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public string Location { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    

    public Manager()
    {

    }

    public Manager(int empID, string empName,string location,string departmentName) : base(empID, empName, location) 
    {
        this._departmentName = departmentName;
    }

    public System.DateTime DateOfBirth
    {
        set
        {
            _dateOfBirth = value;
        }

        get
        {
            return _dateOfBirth;
        }
    }

    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000; //dummy value
    }

    //method Overriding

    public string GetHealthInsuranceAmount() // this method can't be overriden in the corresponding child classes.
    {
        return "Health Insurance premium is : 500";
    }

    public int GetAge()
    {
        return System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays/365);
    }
}


