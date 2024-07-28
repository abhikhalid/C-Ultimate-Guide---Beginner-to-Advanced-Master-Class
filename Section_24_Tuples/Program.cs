using System;

namespace Section_24_Tuples
{
    class Sample
    {
        public Tuple<string,int> GetPersonDetails()
        {
            Tuple<string, int> person = new Tuple<string, int>("Khalid", 20);

            return person;
        }
    }

    
   class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();

            Tuple<string, int> person = s.GetPersonDetails();

            //access values from tuple
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);

            Console.ReadKey();
        }
    }
}
