using Events_ClassLibrary;
using System;

namespace Events_ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //create object of Subscriber class
            Subscriber subscriber = new Subscriber();

            //create object of Publisher class
            Publisher publisher = new Publisher();

            //handle the event (or) subscribe to event
            publisher.myEvent += subscriber.Add;

            //invoke the event
            publisher.RaiseEvent(10,20);
            publisher.RaiseEvent(5,80);
            publisher.RaiseEvent(14,22);

            Console.ReadKey();
        }
    }
}
