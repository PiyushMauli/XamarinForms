using System;

namespace UpDownCasting
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public void Draw()
        {
            //--------
        }
    }
    public class Text : Shape
    {
        public string FontStyle { get; set; }
        public int FontSize { get; set; }

        public void DrawText()
        {
            //---
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new Shape();
            var text = (Text)shape;
            text.
        }
    }
}
