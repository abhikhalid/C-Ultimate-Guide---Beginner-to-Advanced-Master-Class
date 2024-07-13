public interface IEmployee
{
   //auto-properties
   int EmpID { get; set; }
   
   string EmpName { get; set; }

   string Location { get; set; }

   //abstract method
   string GetHealthInsuranceAmount();

}