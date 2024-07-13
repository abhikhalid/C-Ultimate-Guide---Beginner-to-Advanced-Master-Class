public interface  IEmployee
{
   //abstract method
   string GetHealthInsuranceAmount();

   //auto-properties
   //the definition of 'set' and 'get' accessor are written in the child
   // class while implementation of interface.
   //interface member are by default public, we can not explicitly define
   
   
   //Interface stick to the point that, every child class must contain these property.
   //But the interface doesn't involve in the implementation of the property or method.
   // so it is the freddom of the child classes to implement that property and method on it's own.
   int EmpID { get; set; }
   string EmpName { get; set; }
   string Location { get; set; }

}