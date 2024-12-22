namespace interface_enhancements
{
    public interface IEmployee
    {
        public string Name { get; set; }

        //private default interface methods. (Private abstract method is not allowed)
        private string GetNameTitile()
        {
            return "Mr./Ms.";
        }

        //default interface methods or virtual extension method
        internal string GetNameInUpperCase()
        {
            return GetNameTitile() + " " + Name.ToUpper();
        }

        internal string GetNameInLowerCase();

        internal int GetNameLength();
    }

    public class Manager: IEmployee
    {
        private string _name;

        public string Name { get; set; }

        //Option1: You can explicitly implement non-public abstract interface methods.
        string IEmployee.GetNameInLowerCase()
        {
            return Name.ToLower();
        }
        
        //Option 2: You can convert the non-public abstract interface methods as 'public'
        public int GetNameLength()
        {
            return Name.Length;
        }
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
            Console.WriteLine(iemp.GetNameInLowerCase()); //can not call this method with manager obj. because the method is not public
            Console.WriteLine(manager.GetNameLength());
            Console.ReadKey();
        }
    }
}

