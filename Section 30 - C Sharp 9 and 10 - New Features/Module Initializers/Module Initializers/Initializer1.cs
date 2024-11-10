using System.Runtime.CompilerServices;

namespace Initializer
{
    internal class Initializer1
    {
        [ModuleInitializer]
        internal static void Initialize1() // this method should gets executed before Main method.
        {
            Console.WriteLine("From Initialize 1");
        }
    }
}