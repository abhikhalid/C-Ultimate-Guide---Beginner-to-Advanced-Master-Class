﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.Exceptions
{
    /// <summary>
    /// Exception class that represents error raised in Customer class.
    /// </summary>
    public class CustomerException : ApplicationException
    {
        /// <summary>
        /// Constructor that initializes exception message
        /// </summary>
        /// <param name="message">exception messag</param>
        public CustomerException(string message) : base(message)
        {

        }

        /// <summary>
        /// Constructor that initalizes exception message and inner exception.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner Exception</param>
        public CustomerException(string message,Exception innerException) : base(message, innerException)
        {

        }
    }
}
