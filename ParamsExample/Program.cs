class Student
{
    public void DisplaySubjects(params string[] subjects)
    {
        for(int i = 0;i < subjects.Length;i++)
        {
            System.Console.WriteLine(subjects[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        //create object of Student class
        Student s = new Student();
        //access DisplaySubjects method
        s.DisplaySubjects("Theory of Computation", "Computer Networks", "Discrete Mathematics", "Digital System Design");

        System.Console.ReadKey();
    }
}