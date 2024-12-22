using Partial_Method_Return_Type;

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.StudentID = 1;

        Console.WriteLine(s.StudentID);
        Console.ReadKey();
    }
}