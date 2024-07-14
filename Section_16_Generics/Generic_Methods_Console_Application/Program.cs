using System;

class Program
{
    static void Main()
    {
        //create objects
        Sample sample = new Sample();
        Employee employee = new Employee();
        Student student = new Student();


        //call the generic method
        sample.PrintData<Employee>(employee);
        sample.PrintData<Student>(student);

        Console.ReadKey();

    }
}