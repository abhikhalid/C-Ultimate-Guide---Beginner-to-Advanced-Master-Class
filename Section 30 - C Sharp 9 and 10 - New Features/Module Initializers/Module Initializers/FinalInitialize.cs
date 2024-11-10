using Initializer;
using System;
using System.Runtime.CompilerServices;


namespace Module_Initializers
{
    internal class FinalModuleInitialize
    {
        [ModuleInitializer]
        public static void FinalInitialize()
        {
            Initializer2.Initialize2();
            Initializer1.Initialize1();
        }
    }
}
