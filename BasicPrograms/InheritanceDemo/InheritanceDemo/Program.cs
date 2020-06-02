using System;

namespace InheritanceDemo
{
    public class PresentationLogic
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("From Copy() method");
        }
        public void Duplicate()
        {
            Console.WriteLine("From Duplicate() method");
        }
    }
    public class Text : PresentationLogic
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("link added {0}", url);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.AddHyperlink("google.com");
        }
    }
}
