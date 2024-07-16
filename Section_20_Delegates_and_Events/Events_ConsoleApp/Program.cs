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

            publisher.myEvent += delegate (int a, int b) //here we are writing 'delegate' keyword in order to create the anonymous method. It's not actual delegate.
            {
                System.Console.WriteLine(a + b);
            };

            //invoke the event
            publisher.RaiseEvent(10,20);
            publisher.RaiseEvent(5,80);
            publisher.RaiseEvent(14,22);

            Console.ReadKey();
        }
    }
}
