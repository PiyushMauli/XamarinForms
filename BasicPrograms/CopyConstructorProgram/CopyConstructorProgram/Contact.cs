using System;
using System.Collections.Generic;
using System.Text;

namespace CopyConstructorProgram
{
    public class Contact
    {
        public int x;

        static readonly int y;

        static Contact()
        {
            y = 10;
            Console.WriteLine("Value of y is {0}", y);
        }
        public Contact(int i)
        {
            x = i;
        }


        public void Display()
        {
            Console.WriteLine("The value of x is {0}", x);
        }
    }

    public class MainProgram
    {
        
    }
}
