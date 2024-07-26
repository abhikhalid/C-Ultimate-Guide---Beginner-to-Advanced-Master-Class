using System;
using System.Collections.Generic;

namespace Iterator_and_Yield_Return
{
    public class Sample
    {
        public List<double> Prices { get; set; } = new List<double>()
        {
            90,34,12,80
        };

        //Iterator method
        public IEnumerable<double> Method()
        {
            double sum = 0;
            foreach (double price in Prices)
            {
                sum += price;
                yield return sum; // 90,124,136,216
            }
        }
    }


    class Program
    {
        static void Main()
        {
            Sample s = new Sample();
            var enumerable1 = s.Method();
            var prices_enumerator = enumerable1.GetEnumerator();

            prices_enumerator.MoveNext();
            Console.WriteLine("Total price up to first product:"+prices_enumerator.Current);
            Console.WriteLine("Some more code...");

            prices_enumerator.MoveNext();

            Console.WriteLine("Total price up to second product:" + prices_enumerator.Current);
            Console.WriteLine("Some more code...");


            Console.ReadKey();
        }
    }
}
