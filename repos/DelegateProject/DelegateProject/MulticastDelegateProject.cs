using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace DelegateProject
{ 
    public class MulticastDelegateProject
    {
        static void Main(string[] args)
        {
            MulticastDelegateProject md = new MulticastDelegateProject();

            Func<int, double, float, double> ad = (x, y, z) =>
               {
                   return x + y + z;
               };
            Console.WriteLine(ad.Invoke(1, 2.3, 4.5f));

            Action gd = () =>
            {
                Console.WriteLine("Hello");
            };
            gd.Invoke();

            Predicate<string> sd = (str) => str.Length > 5 ? true : false;
            
            Console.WriteLine(sd.Invoke("Hello Piyush Jiwane"));
        }
    }
}
