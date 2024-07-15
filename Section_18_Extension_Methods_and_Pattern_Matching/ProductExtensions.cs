using ClassLibrary1;
using System;

namespace Section_18_Extension_Methods_and_Pattern_Matching
{
    //static class for extension method
    public static class ProductExtensions
    {
        //Extension method for Product Class
        //this method logically becomes as instace method of the Product class
        public static double GetDiscount(this Product product)
        {
            return product.ProductCost * product.DiscountPercentage / 100;
        }
    }
}
