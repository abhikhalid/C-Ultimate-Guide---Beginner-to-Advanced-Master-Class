using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_ClassLibrary
{
    //In publisher class, I wish to create an event. Before doing that, first we require to create a delegate type because events are the delegates that are created based on the delegate types.
    //So, Delegate type is a pre-requisite for working with events.

    //delegate type
    public delegate void MyDelegateType(int a,int b);

    //publisher
    public class Publisher
    {
        //step 2: private delegate
        private MyDelegateType myDelegate;

        //step 1: create an event
        public event MyDelegateType myEvent
        {
            //much like properties, it contains two accessor, Add and Remove
            // The Add accessor executes as soon as when the method is subscribed to the event.
            // That means in the Subscriber class, some method has been subscibed to the event called myEvent.
            // Then automatically the Add method (accessor) will be executed; just like set method in the properties
            // In this case, the method that is assigned from the Subscribed class wil be represented as "value" keyword.
            // the same must be stored in the myEvent. and we require a private delegates in order to store the reference of one or more methods. 
            add
            {
                //step 3: now we have to store the reference of the method in the myDelegate
                myDelegate += value;
            }

            //step 4: we require to add 'remove' accessor which executes when we unsubscribe to the event. It executes whenever the Subscriber class cancels the subscription.
            remove
            {
                myDelegate -= value;
            }
        }

        //Step No: 5
        public void RaiseEvent(int a,int b)
        {
            //raise event

            //if nobody subscribes to the event, in that case myDelegate is null

            if(this.myDelegate != null) // that means, at least one or more methods have been subscribed to the event, then only we have to raise the event.
            {
                this.myDelegate(a, b);
            }
        }
    }
}
