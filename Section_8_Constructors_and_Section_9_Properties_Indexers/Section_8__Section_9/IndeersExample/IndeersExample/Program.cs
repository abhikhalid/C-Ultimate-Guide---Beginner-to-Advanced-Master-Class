class Program
{
    public static void Main()
    {
        Car car = new Car();

        //call get accesssor of indexer
        System.Console.WriteLine(car[0]); // BMW

        car[0] = "Nissan";

        System.Console.ReadKey();
    }
}