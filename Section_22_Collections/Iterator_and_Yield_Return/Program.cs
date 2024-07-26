using System;
using System.Collections.Generic;

namespace Iterator_and_Yield_Return
{
    public class Sample
    {
        public IEnumerable<int> Method()
        {
            Console.WriteLine("Iterator method executes");
            yield return 10; //yield return statement returns a value but continues the execution of that method.
            Console.WriteLine("Iterator method executes conitued");
            yield return 20;
        }
    }


    class Program
    {
        static void Main()
        {
            Sample s = new Sample();
            var enumerable1 = s.Method();


            /*
            var enumerator1 = enumerable1.GetEnumerator();
            enumerator1.MoveNext();
            Console.WriteLine(enumerator1.Current);

            //DOING SOME OTHER TASK HERE
            // ..................
            // ...............
            // .............

            enumerator1.MoveNext();
            Console.WriteLine(enumerator1.Current);
            */

            //ALTERNATIVELY, USE FOR EACH LOOP
            foreach (var item in enumerable1)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
