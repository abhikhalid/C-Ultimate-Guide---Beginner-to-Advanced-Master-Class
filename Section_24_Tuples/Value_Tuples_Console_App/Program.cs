using System;
using Value_Tuples_Class_Library;

namespace ClassLibrary1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();   

            //get details
            //(int customerID, string customerName,string email) cust = customer.GetCustomerDetails();


            //Deconstructing
            //these three become as local variable of the Main method - rather than treating them as fields of the tuple.
            (int customerID, string customerName,string email)  = customer.GetCustomerDetails();

            //Console.WriteLine(cust.customerID);
            //Console.WriteLine(cust.customerName);
            //Console.WriteLine(cust.email);    
            
            
            Console.WriteLine(customerID);
            Console.WriteLine(customerName);
            Console.WriteLine(email);
        
            Console.ReadKey();
        }
    }
}
