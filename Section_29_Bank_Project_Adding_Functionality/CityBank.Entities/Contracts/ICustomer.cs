using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.Entities
{
    /// <summary>
    /// Represents interface of customer entity.
    /// </summary>
    public interface ICustomer
    {
        #region Properties
        Guid CustomerID { get; set; }

        long CustomerCode { get; set; }

        string CustomerName { get; set; }

        string Address { get; set; }

        string LandMark { get; set; }

        string City { get; set; }

        string Country { get; set; }

        string Mobile { get; set; }
        #endregion
    }
}
