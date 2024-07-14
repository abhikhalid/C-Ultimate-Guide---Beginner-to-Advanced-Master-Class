public partial class Product
{
    //private field
    private double _cost;

    //public field
    public double Cost
    {
        set { _cost = value; }
        get { return _cost; }
    }

    //Implementation of partial method
    partial void GetTax2()
    {
        double tax = Cost * 10 / 100;

    }
}