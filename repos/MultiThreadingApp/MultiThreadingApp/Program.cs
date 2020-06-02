using System;
using System.Threading;

namespace MultiThreadingApp
{
    class Program
    {
        public void Test1()
        {
            
                Console.Write("Hello... ");
                Thread.Sleep(5000);
                Console.WriteLine("Piyush !!!");
           
        }
       
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread T1 = new Thread(p.Test1);
            Thread T2 = new Thread(p.Test1);
            Thread T3 = new Thread(p.Test1);
            T1.Start();T2.Start();T3.Start();
        }
    }
}
