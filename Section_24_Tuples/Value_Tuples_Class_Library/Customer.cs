using System;
namespace Value_Tuples_Class_Library
{
    public class Customer
    {
        public (int customerID,string customerName, string email) GetCustomerDetails()
        {
            return (101,"Khalid","khalid@gmail.com");
        }
    }
}
