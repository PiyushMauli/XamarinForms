using System;
using System.Collections.Generic;
using System.Text;

namespace GetterSetterEx
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
    class IndexsersDemo
    {
        static void Main(string[] args)
        {
            var httpCookie = new HttpCookie();
            httpCookie["name"] = "Piyush";
            Console.WriteLine("Name is ",httpCookie["name"]);
        }
    }
}
