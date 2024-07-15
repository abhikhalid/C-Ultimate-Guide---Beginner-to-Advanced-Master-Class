using Inner_Classes_Class_Library;
using System;

namespace Inner_Classes_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object of inner class
            MarksCalculation.CalculationHelper calculationHelper = new MarksCalculation.CalculationHelper();
            //call the inner class's method
            Console.WriteLine(calculationHelper.Multipy(10, 5));

            //call outer class's method
            MarksCalculation mc = new MarksCalculation();
            Student s = new Student() { SecuredMarks = 35, MaxMarks = 50 };
            mc.CalculatePercentage(s);

            Console.WriteLine(s.Percentage);

            Console.ReadKey();
        }
    }
}
