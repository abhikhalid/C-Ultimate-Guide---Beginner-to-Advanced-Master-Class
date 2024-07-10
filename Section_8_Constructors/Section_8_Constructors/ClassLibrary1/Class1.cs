public class Employee
{
    //fields
    public int empID;
    public string empName;
    public string job;

    public static string companyName;

    //constructor
    public Employee()
    {
        empID = 101;
        empName = "No name";
        job = "some job title";
    }

    public Employee(int empID, string empName, string job)
    {
        this.empID = empID;
        this.empName = empName;
        this.job = job;
    }

    // static constructor is public by default. 
    // It can not have any parameters.
    static Employee()
    {
        companyName = "BJIT LTD.";
    }
}
