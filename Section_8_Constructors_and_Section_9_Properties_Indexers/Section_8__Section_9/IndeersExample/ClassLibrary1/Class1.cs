public class Car
{
    //private 
    private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };

    //public indexer
    public string this[int index]
    {
        set
        {
            this._brands[index] = value;
        }

        get { return this._brands[index]; }
    }
}