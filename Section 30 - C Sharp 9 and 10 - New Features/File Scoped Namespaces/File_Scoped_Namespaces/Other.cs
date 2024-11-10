Something something = new Something();
Console.WriteLine(something.student);
Console.WriteLine(something.teacher);
Console.ReadKey();

// this class is no longer part of namespace 'College'
class Something
{
    public College.Student student = new College.Student();
    public College.Teacher teacher = new College.Teacher();

}