namespace interface_enhancements
{
    public interface IEmployee
    {
        public string Name { get; set; }

        //default interface methods or virtual extension method
        public string GetNameInUpperCase()
        {
            return Name.ToUpper();
        }
    }

    public class Manager: IEmployee
    {
        private string _name;

        public string Name { get; set; }
    }

    public class Clert: IEmployee
    {
        private string _name;

        public string Name { get; set; }
    }


    class Program
    {
        static void Main()
        {
            Manager manager = new Manager();
            manager.Name = "Khalid";
            //Console.WriteLine(manager.Name);
            IEmployee iemp = (IEmployee)manager;

            Console.WriteLine(iemp.GetNameInUpperCase());
            Console.ReadKey();
        }
    }
}

