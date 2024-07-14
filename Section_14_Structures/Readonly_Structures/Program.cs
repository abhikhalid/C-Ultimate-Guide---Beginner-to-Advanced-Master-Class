using System;

class Program
{
    public static void Main()
    {
        Marvel m = new Marvel("IRON MAN");

        Console.WriteLine(m.CharacterName);
        m.PrintCharacterName();

        Console.ReadKey();

    }
}