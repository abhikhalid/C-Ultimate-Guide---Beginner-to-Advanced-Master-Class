using System;

class Sample
{
    static void Main() // Return type of Main method  should be (void or int) and it should be static
    {
        // System is a predefined Namespace which is a part of BCL.
        // Inside that Namespace, we have Console Class. 
        // Inside Console Class, we have predefined static 'WriteLine' method.
        System.Console.WriteLine("Hello");
       // System.Console.ReadKey(); // hey console, wait for the user until user press any key on the keyboard.


        //Print messages line-by-line
        System.Console.WriteLine("Welcome");
        System.Console.WriteLine("to");
        System.Console.WriteLine("C# Programming");

        //Print messages side-by-side
        System.Console.Write("Welcome");
        System.Console.Write(" to ");
        System.Console.Write("C# Programmiong");

        //Wait for pressing some key on keyboard
        System.Console.ReadKey();

        // clear the screen
        System.Console.Clear();

        System.Console.WriteLine("Thank you");
        Console.ReadKey();
    }
}