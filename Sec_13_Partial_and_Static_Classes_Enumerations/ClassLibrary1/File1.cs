public partial class Product
{
    //private field
    private int _productID;

    //public property
    public int ProductID
    {
        set
        {
            this._productID = value;
        }
        get
        {
            return this._productID;
        }
    }
}