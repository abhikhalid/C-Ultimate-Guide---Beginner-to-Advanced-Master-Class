using System;

class Person
{
    public int? NoOfChildren;
}


class Program
{
    static void Main()
    {
        //create object
        Person p1 = new Person() { NoOfChildren = 1 };
        Person p2 = new Person() { NoOfChildren = null };
        Person p3 = null;


        Console.WriteLine(p1.NoOfChildren);
  
        if(p2.NoOfChildren != null) //p2.NoOfChildren.HasValue
        {
            Console.WriteLine(p2.NoOfChildren);
        }

        Console.ReadKey();
    }
}