using CityBank.Exceptions;
using System;

namespace CityBank.Entities
{
    /// <summary>
    /// Represents customer of the bank.
    /// </summary>
    public class Customer : ICustomer, ICloneable
    {
        private long _customerCode;
        private string _customerName;
        private string _mobile;

        #region Public Properties

        /// <summary>
        /// Guid of Customer Unique identification
        /// </summary>
        public Guid CustomerID { get ; set ; }

        /// <summary>
        /// Auto-generated code number of the customer
        /// </summary>
        public long CustomerCode
        { 
            get => _customerCode ;

            set
            {
                //customer code should be positive
                if (value > 0)
                {
                    _customerCode = value;
                }
                else
                {
                    throw new CustomerException("Customer code should be positive only");
                }
            } 
        }

        /// <summary>
        /// Name of the customer
        /// </summary>
        public string CustomerName 
        {
            get => _customerName;
            set
            {
                //customer name should be less than 40 characters.
                if(value.Length <= 40 && !string.IsNullOrEmpty(value))
                {
                    _customerName = value;
                }
                else
                {
                    throw new CustomerException("Customer Name should not be null and less than 40 characters long.");
                }
            }
        }

        /// <summary>
        /// Address of the customer
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Landmark of the customer's address
        /// </summary>
        public string LandMark { get; set; }

        /// <summary>
        /// City of the customer
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Country of the customer
        /// </summary>
        public string Country { get; set;}

        /// <summary>
        /// 10-digit Mobile number of the customer
        /// </summary>
        public string Mobile
        {
            get => _mobile;
           
            set
            {
                //mobile number should be 10 digit mobile number.
                if(value.Length == 10)
                {
                    _mobile = value;
                }
                else
                {
                    throw new CustomerException("Mobile number should be a 10-digit mobile number");
                }
            }
        }

        public object Clone()
        {
            return new Customer()
            {
                CustomerID = this.CustomerID,
                CustomerCode = this.CustomerCode,
                CustomerName = this.CustomerName,
                Address = this.Address,
                LandMark = this.LandMark,
                City = this.City,
                Country = this.Country,
                Mobile = this.Mobile
            };
        }
        #endregion


    }
}
