using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The 'Class Library' is a collection of classes that will be compiled as a 'dll' (Dynamic Link Library) file and that 'dll' file reference can be added
// to the console application. The the console application can access any class that is present inside the class libary.
namespace ClassLibrary1
{
    public class Customer
    {
        public int customerID;
        public string customerName;
    }
}
