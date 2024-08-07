using CityBank.Configuration;
using CityBank.DataAccesLayer;
using CityBank.DataAccesLayer.DALContracts;
using CityBank.Entities;
using CityBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.BusinessLogicLayer
{
    /// <summary>
    /// Represents customer business logic
    /// </summary>
    public class CustomersBusinessLogicLayer : ICustomersBusinessLogicLayer
    {
        #region Private Fields
        private ICustomerDataAccessLayer _customersDataAccessLayer;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor that initializes CustomersDataAccessLayer
        /// </summary>
        public CustomersBusinessLogicLayer()
        {
            _customersDataAccessLayer = new CustomerDataAccessLayer();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Private property that represents reference of CustomersDataAccessLayer
        /// </summary>
        public ICustomerDataAccessLayer CustomerDataAccessLayer
        {
           set => _customersDataAccessLayer = value;
           get => _customersDataAccessLayer;
        }
        #endregion


        public Guid AddCustomer(Customer customer)
        {
            try
            {
                //get all customers
                List<Customer> allCustomers = CustomerDataAccessLayer.GetCustomers();
                long maxCustCode = 0;

                foreach(var item in allCustomers)
                {
                    if(item.CustomerCode > maxCustCode)
                    {
                        maxCustCode = item.CustomerCode;
                    }
                }

                //generate new customer no
                if(allCustomers.Count >= 1)
                {
                    customer.CustomerCode = maxCustCode + 1;
                }
                else
                {
                    customer.CustomerCode = Settings.BaseCustomerNo + 1;
                }

                //invoke Data Access Layer
                return CustomerDataAccessLayer.AddCustomer(customer);
            }
            catch(CustomerException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteCustomer(Guid customerId)
        {
            try
            {
                //invoke Data Access Layer
                return CustomerDataAccessLayer.DeleteCustomer(customerId);
            }
            catch (CustomerException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns>List of customers</returns>
        public List<Customer> GetCustomers()
        {
            try
            {
                //invoke DAL
                return CustomerDataAccessLayer.GetCustomers();
            }
            catch (CustomerException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Returns a set of customers that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lamda expression that contains condition to check</param>
        /// <returns>The list of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                //invoke Data Access Layer
                return CustomerDataAccessLayer.GetCustomersByCondition(predicate);
            }
            catch(CustomerException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                //invoke Data Access Layer
                return CustomerDataAccessLayer.UpdateCustomer(customer);
            }
            catch (CustomerException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
