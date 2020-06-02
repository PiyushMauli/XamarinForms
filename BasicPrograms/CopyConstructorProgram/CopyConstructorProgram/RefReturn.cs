using System;
using System.Collections.Generic;
using System.Text;

namespace CopyConstructorProgram
{
    class GetColor{
        public static ref string FetchColor(string[] arr, int i){
            return ref arr[i];
        }
    }
    class RefReturn{
        static void Main(string[] args){
            string[] Colors = { "a", "b", "c", "d" };
            ref string color = ref GetColor.FetchColor(Colors, 2);
            Console.WriteLine(color);
            Console.WriteLine(String.Join("-",Colors));

            color = "Brown";
            Console.WriteLine( color);
            Console.WriteLine(String.Join("-",Colors));

        }
    }
}
