class Program
{
    // We can create multiple 'module initializer' in a same project. 
    // In that case, which 'module initializer' gets called first? ans is alphabatecally? 
    // In case if you want to change the order of calling of 'module initializer', create another class.
    static void Main()
    {
        Console.WriteLine("From Main");
    }
}