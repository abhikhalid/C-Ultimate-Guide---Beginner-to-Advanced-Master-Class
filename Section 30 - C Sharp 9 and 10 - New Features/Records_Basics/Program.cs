namespace records_example
{
    public interface IPerson
    {
        string Name { get; init; }
    }

    public abstract record Person(string? Name, DateTime? DateOfBirth, int? Age) : IPerson
    {
        //user-defined constructor
        public Person(string name, DateTime? dateOfBirth) : this(name, dateOfBirth, null)
        {
            if (dateOfBirth != null)
            {
                Age = Convert.ToInt32(DateTime.Now.Subtract(dateOfBirth.Value).TotalDays / 365.25);
            }
        } 

        //user-defined constructor (parameter-less)
        public Person(): this(null,null,null)
        {
          
        }

        //Records are classes internally. so we can create user-defined methods here.
        public string GetName()
        {
            return $"Mr.Ms.{Name}";
        }

        public override string ToString()
        {
            return $"Name is {Name}";
        }
    }


    public sealed record Employee(string? Name, DateTime? DateOfBirth, double? Salary) : Person(Name, DateOfBirth)
    {
        public sealed override string ToString()
        {
            return $"Salary is {Salary},{base.ToString()}";
        }
    }
    
    //public sealed record Manager : Employee(null, null, null)
    //{
    //    //public override string ToString() // Error: can not override inherited member ToString()
    //    //{
    //    //    return "some value";
    //    //}
    //}

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee("Khalid",DateTime.Parse("1996-07-14"),100000);
            Console.WriteLine(emp);

            Console.ReadKey();
        }
    }


}