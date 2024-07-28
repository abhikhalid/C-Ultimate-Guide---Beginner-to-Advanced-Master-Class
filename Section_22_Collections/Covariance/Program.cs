using System;
using System.Collections.Generic;

namespace Covariance
{
    class LivingThing
    {
        public int NumberOfLegs { get; set; }
    }

    class Parrot: LivingThing
    {

    }

    class Dog: LivingThing
    {

    }

    interface IMover<out T>
    {
        T Move();
    }

    class Mover<T> : IMover<T>
    {
        public T thing { get; set; }

        public T Move()
        {
            return thing;
        }
    }

    class Sample
    {
        //public void PrintValues(List<string> values)
        //{
        //    foreach (var item in values)
        //    {
        //        Console.WriteLine(item + ",");
        //    }
        //    Console.WriteLine();
        //}

        // but I want to receive all kind of list

        //public void PrintValues(List<Object> values)
        //{
        //    foreach (var item in values)
        //    {
        //        Console.WriteLine(item + ",");
        //    }
        //    Console.WriteLine();
        //}

        // but it does not work? so, this the case when we need Co-variance.

        //IEnumerable already implemented covariance concept.
        public void PrintValues(IEnumerable<Object> values)
        {
            foreach (var item in values)
            {
                Console.WriteLine(item + ",");
            }
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main()
        {
            //create object
            LivingThing livingThing = new Parrot(); //not covariance
            Parrot parrot = new Parrot() { NumberOfLegs = 2}; //normal

            //Mover<Parrot> mover = new Mover<Parrot>();
            //IMover<Parrot> mover = new Mover<Parrot>();
            //Mover<LivingThing> mover1 = new Mover<Parrot>(); //error

            IMover<LivingThing> mover = new Mover<Parrot>()
            {
                thing = parrot
            };

            Console.WriteLine("Moving with " + mover.Move().NumberOfLegs+" Legs.");


            Sample s = new Sample();
            s.PrintValues(new List<string>
            {
                "Hello",
                "World",
                "Bangladesh"
            });

            //so, covariance is about supplying the child type name wherever the parent is expected.
            Console.ReadKey();
        }
    }
}
