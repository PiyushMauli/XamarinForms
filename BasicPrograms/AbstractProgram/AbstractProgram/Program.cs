using System;

namespace AbstractProgram
{
    class Program
    {
        public abstract class Calculator
        {
            public void Add(int x,int y)
            {
                Console.WriteLine(x+y);
            }
            public void Sub(int x,int y)
            {
                Console.WriteLine(x-y);
            }
            public abstract void Mul(int x, int y);
            public abstract void Div(int x, int y);
        }
        public class CalculatorImplementation : Calculator
        {
            public override void Mul(int x, int y)
            {
                Console.WriteLine(x*y);
            }
            public override void Div(int x, int y)
            {
                Console.WriteLine(x/y);
            }
            public void Tp()
            {
                Console.WriteLine("Tp");
            }
        }
        static void Main(string[] args)
        {
            CalculatorImplementation ci = new CalculatorImplementation();
            ci.Add(10, 20);
            ci.Sub(20, 10);
            ci.Mul(10, 20);
            ci.Div(20, 10);
            ci.Tp();
        }
    }
}
