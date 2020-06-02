using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApplication
{
    interface MultipleInheritance1
    {
        void Test();
    }
    interface MultipleInheritance2
    {
        void Test();
    }

    public class ImplimentationInterface : MultipleInheritance1, MultipleInheritance2
    {
        void MultipleInheritance1.Test()
        {
            Console.WriteLine("From MI1");
        }
        void MultipleInheritance2.Test()
        {
            Console.WriteLine("From MI2");
        }
        static void Main(string[] args)
        {
            ImplimentationInterface mi = new ImplimentationInterface();
            MultipleInheritance1 mi1 = mi;
            MultipleInheritance2 mi2 = mi;

            mi1.Test();
            mi2.Test();
        }
    }
}
