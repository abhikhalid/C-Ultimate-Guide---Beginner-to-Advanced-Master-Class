using System;
namespace Contravariance
{
    class LivingThing
    {
        public int NumberOfLegs { get; set; }
    }

    class Parrot : LivingThing
    {

    }

    class Dog: LivingThing
    {

    }

    interface IMover<in T> //contravariance
    {
        void Move(T x);
    }

    public class Mover<T>: IMover<T>
    {
        public void Move(T x)
        {
            if(x is Parrot)
            Console.WriteLine("Moving wwith " + (x as Parrot).NumberOfLegs + " legs.");
            else
                Console.WriteLine("Moving wwith " + (x as Dog).NumberOfLegs + " legs.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create normal object
            Parrot parrot = new Parrot()
            {
                NumberOfLegs = 2
            };


            Dog dog = new Dog()
            {
                NumberOfLegs = 4
            };

            //Contravariance = supply the parent type name, where the child type name is expected.
            IMover<Parrot> obj1 = new Mover<Parrot>();

            //Parrot vs Livingthing; supplying the parent type (LivingThing), where the child type Parrot is expected.
            IMover<Parrot> obj2 = new Mover<LivingThing>(); //Contravariance


            obj2.Move(parrot);

            IMover<Dog> obj3 = new Mover<LivingThing>();
            obj3.Move(dog); 

            Console.ReadKey();

        }
    }
}
