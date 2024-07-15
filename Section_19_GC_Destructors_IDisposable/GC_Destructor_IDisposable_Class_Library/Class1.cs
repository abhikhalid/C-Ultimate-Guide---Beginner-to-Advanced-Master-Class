using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Destructor_IDisposable_Class_Library
{
    public class Sample
    {
        //constructor
        public Sample()
        {
            //file and db connection logic here
            Console.WriteLine("File is opened");
        }

        //destructor
        // The destructor executes automatically before deleting object from the memory.
        // Generally, objects are deleted at the end of the application, thats when the destructor gets called before end of the application.
        // So in real-time applications you can use the destructors in order to close the files or database connections that are open by the constructor.
        ~Sample() 
        { 
            //file and db closing logic here
            Console.WriteLine("File is closed");
        }
    }
}
