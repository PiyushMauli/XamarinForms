using System;

namespace RefProgram
{
    public class MyClass { 
        public static void MyMethod(ref int a)
        {
             a += 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            Console.WriteLine("Value of a is {0}", ref a);
        }
    }
}
