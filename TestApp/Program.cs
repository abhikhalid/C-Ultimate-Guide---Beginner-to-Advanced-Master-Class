class Sample
{
    static void Main() // Return type of Main method  should be (void or int) and it should be static
    {
        // System is a predefined Namespace which is a part of BCL.
        // Inside that Namespace, we have Console Class. 
        // Inside Console Class, we have predefined static 'WriteLine' method.
        System.Console.WriteLine("Hello");
        System.Console.ReadKey(); // hey console, wait for the user until user press any key on the keyboard.
    }
}