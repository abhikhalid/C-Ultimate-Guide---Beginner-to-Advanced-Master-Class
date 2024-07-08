using System;

class Sample
{
    static void Main() // Return type of Main method  should be (void or int) and it should be static
    {
        //declare the variable
        int a = 100;
        //print value
        System.Console.WriteLine(a);
     

        string studentName = "Khalid";
        int age = 20;

        //print value
        System.Console.Write("Hey");
        System.Console.Write(studentName);
        System.Console.Write(". your age is");
        System.Console.Write(age);

        //wait for pressing some key
        System.Console.ReadKey();
    }
}