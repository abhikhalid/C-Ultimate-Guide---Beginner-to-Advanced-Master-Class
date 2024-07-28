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


            //DisCards
            (int customerID, _, string email)  = customer.GetCustomerDetails();

            //Console.WriteLine(cust.customerID);
            //Console.WriteLine(cust.customerName);
            //Console.WriteLine(cust.email);    
            
            
            Console.WriteLine(customerID);
            Console.WriteLine(email);
        
            Console.ReadKey();
        }
    }
}
