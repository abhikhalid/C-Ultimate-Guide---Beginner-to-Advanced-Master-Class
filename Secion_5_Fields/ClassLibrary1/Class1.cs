public class Product
{
    //fields
    //public int productID=1001; (not good way)
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Computer";
    public readonly string dateofPurchase;

    public Product()
    {
        dateofPurchase = System.DateTime.Now.ToShortDateString();
    }

    public void Method()
    {
        TotalNoProducts = 0;
    }
}