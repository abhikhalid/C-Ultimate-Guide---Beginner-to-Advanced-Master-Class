using Events_ClassLibrary;
using System;

namespace Events_ConsoleApp
{
    // Since you have written the anonymous method inside the Program.cs file, the program file itself becomes as Subscriber class.
    class Program
    {
        static void Main()
        {
            //create object of Subscriber class
            Subscriber subscriber = new Subscriber();

            //create object of Publisher class
            Publisher publisher = new Publisher();

            //handle the event (or) subscribe to event
            //publisher.myEvent += subscriber.Add;

            publisher.myEvent += (a) => {
                return a >= 0;
            };

            //invoke the event
            Console.WriteLine(publisher.RaiseEvent(10));
            Console.WriteLine(publisher.RaiseEvent(-5));
            Console.WriteLine(publisher.RaiseEvent(-14));

            Console.ReadKey();
        }
    }
}
