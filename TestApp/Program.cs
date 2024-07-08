using System;

class Sample
{
    static void Main()
    {
        // 1 to 10
        int i = 1;
        while (i <= 10)
        {
            System.Console.WriteLine(i + "");
            i++;
        }

        // 9 to 0
        i = 9;
        while (i >= 0)
        {
            System.Console.WriteLine(i + "");
            i--;
        }

        i = 9;
        do 
        {
            System.Console.WriteLine(i + "");
            i--;
        }while (i >= 0);

        System.Console.ReadKey();
    }
}