public abstract class Student
{
    //abstract property
    public abstract int Marks { get; set; }
}

public class GraduateStudent : Student
{
    public override int Marks { get; set; }
}

public class PostGraduateStudent : Student
{
    public override int Marks { get; set; }
}

//Generic Class
public class MarksPrinter<T> where T : Student
{
    public T stud;

    public void PrintMarks()
    {
        Student temp = (Student)stud;
        System.Console.WriteLine(temp.Marks);
    }
}