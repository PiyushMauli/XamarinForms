using System;

namespace InterfaceApplication
{
    interface ICalculator
    {
        void Add(int a, int b);
        void Sub(int a, int b);
    }

    public class Calculator : ICalculator
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a,int b)
        {
            Console.WriteLine(a-b);
        }
        
    }
}
