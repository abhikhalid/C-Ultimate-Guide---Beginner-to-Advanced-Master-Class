using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Reverse_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a list
            List<double> myNumbers = new List<double>()
            {
                170,150,445,120,10,4,661
            };

            //sort - asc
            myNumbers.Sort();

            //reerse - sort in desc
            myNumbers.Reverse();

            //after sorting
            foreach (double number in myNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
