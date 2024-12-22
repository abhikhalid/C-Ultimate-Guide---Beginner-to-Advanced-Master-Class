class Example
{
    public const string BaseUrl = "http://www.example.com";
    public const string ApiUrl = $"{BaseUrl}/api"; //except, constant other type field not allowed in string interpolation
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Example.BaseUrl);
        Console.ReadKey();
    }
}