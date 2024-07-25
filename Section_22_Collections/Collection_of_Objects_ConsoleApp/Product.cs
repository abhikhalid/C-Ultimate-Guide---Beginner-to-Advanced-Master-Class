using System;

namespace Collection_of_Objects_ConsoleApp
{
    /// <summary>
    /// This is a XML tag.
    /// Represents a Product in ECommerce application.
    /// </summary>
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public DateTime DateOfManufacture {  get; set; }    
    }
}
