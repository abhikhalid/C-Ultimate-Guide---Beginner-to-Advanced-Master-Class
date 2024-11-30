enum MaritalStatus
{
    Unmarried, Married
}

class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }

    public MaritalStatus PersonMaritalStatus { get; set; }

    // I would like to allow this class to be desconstructed.
    // this method will be automatically called by switch expression.
    public void Deconstruct(out Person person, out string? gender, out int? age, out MaritalStatus maritalStatus)
    {
        //person = this;
        //gender = this.Gender;
        //age = this.Age;
        //maritalStatus = this.PersonMaritalStatus;

        //or
        (person,gender,age,maritalStatus) = (this, this.Gender, this.Age, this.PersonMaritalStatus);
    }
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

    //public static string GetDescription2(Person person)
    //{
    //    string result = person switch
    //    {
    //        Person p when p.Age < 13 => $"{p.Name} is Child",
    //        Person p when p.Age < 20 && p.Age >= 13 => $"{p.Name} is a Teenager",
    //        Person p when p.Age >= 20 && p.Age < 60 => $"{p.Name} is Adult",
    //        Person p when p.Age >= 60 => $"{p.Name} is a senior citizen",
    //        _ => $"{person.Name} is a person"
    //    };

    //    return result;
    //}

    //public static string GetDescription2(Person person)
    //{
    //    string result = person switch
    //    {
    //        //is => Relational Pattern
    //        // and or => Logical Pattern
    //        Person p when p.Age is < 13 => $"{p.Name} is Child",
    //        Person p when p.Age is < 20 and  >= 13 => $"{p.Name} is a Teenager",
    //        Person p when p.Age is >= 20 and < 60 => $"{p.Name} is Adult",
    //        //Person p when p.Age >= 60 => $"{p.Name} is a senior citizen",
    //        Person p when p.Age is >= 60 and not (100 or 200) => $"{p.Name} is a senior citizen",
    //        Person p when p.Age is 100 or 200 => $"{p.Name} is Centenarian",
    //        _ => $"{person.Name} is a person"
    //    };

    //    return result;
    //}

    public static string GetDescription2(Person person)
    {
        string result = person switch
        {
            Person {Age: < 13 } p => $"{p.Name} is Child",
            Person {Age: < 20 and >= 13 } p => $"{p.Name} is a Teenager",
            Person {Age: >= 20 and < 60 } p  => $"{p.Name} is Adult",
            //Person p when p.Age >= 60 => $"{p.Name} is a senior citizen",
            Person {Age: >= 60 and not (100 or 200) } p => $"{p.Name} is a senior citizen",
            Person {Age: 100 or 200 } p => $"{p.Name} is Centenarian",
            _ => $"{person.Name} is a person"
        };

        return result;
    }

    //public static string GetDescription3(Person person)
    //{
    //    // Master, Mr, Miss, Ms, Mx
    //    return person switch
    //    {
    //        Person { Gender: "Female", PersonMaritalStatus: MaritalStatus.Unmarried } => $"Miss.{person.Name}",
    //        Person { Gender: "Female", PersonMaritalStatus: MaritalStatus.Married } => $"Mrs.{person.Name}",
    //        Person { Gender: "Male", Age: < 18 } => $"Master.{person.Name}",
    //        Person { Gender: "Male", Age: >= 18 } => $"Mr {person.Name}",
    //        Person { Gender: not("Male" or "Female")} => $"Mx {person.Name}",
    //        _=> $"{person.Name}"
    //    };
    //}
    
    public static string GetDescription3(Person person)
    {
        // Master, Mr, Miss, Ms, Mx
        //return (person, person.Gender, person.Age, person.PersonMaritalStatus) switch
        return person switch
        {
            (Person, "Female",_,MaritalStatus.Unmarried) => $"Miss.{person.Name}",
            (Person, "Female",_,MaritalStatus.Married) => $"Mrs.{person.Name}",
            (Person, "Male", <18, _) => $"Master.{person.Name}",
            (Person, "Male", >=18, _) => $"Mr {person.Name}",
            (Person, not ("Male" or "Female"), _, _) => $"Mx {person.Name}",
            _=> $"{person.Name}"
        };
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
            Salary = 3000,
            PersonMaritalStatus = MaritalStatus.Married,
        };

        Customer customer = new Customer()
        {
            Name = "Smith",
            Gender = "Male",
            Age = 30,
            CustomerBalance = 1000,
            PersonMaritalStatus = MaritalStatus.Unmarried,

        };

        //Console.WriteLine(Descripter.GetDescription(manager));
        //Console.WriteLine(Descripter.GetDescription(customer));
        //Console.WriteLine(Descripter.GetDescription2(manager));
        Console.WriteLine(Descripter.GetDescription3(manager));

        Console.ReadKey();
    }
}