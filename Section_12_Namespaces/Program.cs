using HR;
using m = HR.Mgr;
using FrontOffice;
using static System.Console;

class Program
{
    static void Main()
    {
        m.Manager manager;
        manager = new m.Manager();

        CustomerEnquiry customerEnquiry = new CustomerEnquiry();

        WriteLine("Hello"); // we can write like this by directly assecing it.

        ReadKey();
    }
}