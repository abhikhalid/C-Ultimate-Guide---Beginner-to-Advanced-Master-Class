using static System.Console;

class Program
{
    static void Main()
    {
        //create object of Partial Class
        Product product = new Product();

        //acess properties
        product.ProductID = 101;
        product.Cost = 1000;

        //access methods
        WriteLine(product.GetTax());

        ReadKey();
    }
}