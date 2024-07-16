using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Cast_Delegate_ClassLibrary
{
    public class Sample
    {
        //target mehod 1
        public void Add(double a, double b)
        {
            Console.WriteLine("Addition is: " + (a + b));
        }

        //target mehod 2
        public void Multiply(double a, double b)
        {
            Console.WriteLine("Multipication is : " + (a * b));
        }

    }
}
