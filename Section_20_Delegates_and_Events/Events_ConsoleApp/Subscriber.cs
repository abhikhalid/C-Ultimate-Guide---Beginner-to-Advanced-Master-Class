using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_ConsoleApp
{
    //Subscriber class wants to subscribes to the event. That means assigns the reference of one or more methods to the event.
    class Subscriber
    {
        //target method, that I wish to execute as soon the event is raised is that "Add" method.
        // I want to execute this target method as soon as the event is raised. But raising the event is not in the hands of Subscriber.
        // The only intention of the Subscriber is that, it can say that the Add method should be executed as soon as the Publisher class raises the event.
        public void Add(int a,int b) // (Event handler)
        {
            System.Console.WriteLine(a + b);
        }
    }
}
