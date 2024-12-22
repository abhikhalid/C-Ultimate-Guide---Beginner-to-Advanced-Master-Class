namespace records_example
{
    public record Person(string? Name, DateTime? DateOfBirth, int? Age)
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
    }

        public record Address(string City, string Country)
        {
            public override string ToString()
            {
                return $"City is {City} in {Country}";
            }
        }

        class Program
        {
            static void Main()
            {
                Person person1 = new Person("John", DateTime.Parse("1996-07-14"));

                Console.WriteLine(person1.ToString());

                Console.WriteLine(person1.GetName());

                Console.ReadKey();
            }
        }
 }