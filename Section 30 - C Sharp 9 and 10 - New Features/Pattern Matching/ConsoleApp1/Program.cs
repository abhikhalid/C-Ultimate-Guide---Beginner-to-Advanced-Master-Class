class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }
}

class Employee : Person
{
    public double? Salary { get; set; }
}

class Customer : Person
{
    public double? CustomerBalance { get; set; }
}

class Supplier: Person
{
    public double? SupplierBalance { get; set; }
}

class Manager : Employee
{

}

class Descripter
{
    public static string GetDescription(Person person)
    {
        switch (person)
        {
            case Employee emp:
            
                return $"{person.Name},{person.Age},{person.Gender},{emp.Salary}";
                break; //break statement is optional here because we have already used return keyword.

            case Customer cst:
                return $"{person.Name}, {person.Age},{person.Gender},{cst.CustomerBalance}";
                break ;

            case Supplier sup:
                return $"{person.Name},{person.Age},{person.Gender},{sup.SupplierBalance}";
                break;
            default:
                return $"{person.Name},{person.Age},{person.Gender}";

        }
    }

    //public static string GetDescription2(Person person)
    //{
    //    switch (person)
    //    {
    //        case Person p when p.Age < 20 && p.Age >= 13:
    //            return $"{p.Name} is a Teenager";
    //        case Person p when p.Age < 13:
    //            return $"{p.Name} is Child";
    //        case Person p when p.Age >= 20 && p.Age < 60:
    //            return $"{p.Name} is Adult";
    //        case Person p when p.Age >= 60:
    //            return $"{p.Name} is a senior citizen";
    //        default:
    //            return $"{person.Name} is a person";
    //    }
    //}
    
    public static string GetDescription2(Person person)
    {
        string result = person switch
        {
            Person p when p.Age < 13 => $"{p.Name} is Child",
            Person p when p.Age < 20 && p.Age >= 13 => $"{p.Name} is a Teenager",
            Person p when p.Age >= 20 && p.Age < 60 => $"{p.Name} is Adult",
            Person p when p.Age >= 60 => $"{p.Name} is a senior citizen",
            _ => $"{person.Name} is a person"
        };

        return result;
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager()
        {
            Name = "John",
            Gender = "Male",
            Age = 10,
            Salary = 3000
        };

        Customer customer = new Customer()
        {
            Name = "Smith",
            Gender = "Male",
            Age = 30,
            CustomerBalance = 1000
        };

        Console.WriteLine(Descripter.GetDescription(manager));
        Console.WriteLine(Descripter.GetDescription(customer));
        Console.WriteLine(Descripter.GetDescription2(manager));

        Console.ReadKey();
    }
}