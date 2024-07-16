using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_ClassLibrary
{
    //In publisher class, I wish to create an event. Before doing that, first we require to create a delegate type because events are the delegates that are created based on the delegate types.
  
    //delegate type
    //public delegate int MyDelegateType(int a,int b);

    //publisher
    public class Publisher
    {
        //step 1: create an event
        public event Predicate<int> myEvent; //internally C# compiler automatically creates the code for add and remove accessors and also creates private delegate.

        //Step No 2:raise event
        public bool RaiseEvent(int a)
        {
            //if nobody subscribes to the event, in that case myEvent is null
            if (this.myEvent != null) // that means, at least one or more methods have been subscribed to the event, then only we have to raise the event.
            {
                return this.myEvent(a);
            }
            else return false;
        }
    }
}
