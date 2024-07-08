using System;

class Sample
{
    static void Main()
    {
        //1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // 9 to 0
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        System.Console.ReadKey();
    }
}