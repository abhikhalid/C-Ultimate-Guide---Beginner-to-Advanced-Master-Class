public abstract class Employee
{
   private int _empID;
   private string _empName;
   private string _location;

   public Employee()
   {

   }

   public Employee(int empID, string empName, string location)
   {
        this._empID = empID;
        this._empName = empName;
        this._location = location;
   }


   //abstract method
   public abstract string GetHealthInsuranceAmount();

}