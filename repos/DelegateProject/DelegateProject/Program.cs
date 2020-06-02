using System;

namespace DelegateProject
{
    public delegate void AddNumDelegate(int x, int y);
    public delegate string AddStringDelegate(string lname);
    class Program
    {
        public void AddNum(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public static string AddString(string lname)
        {
            return "Piyush " + lname;
        }
        
    }
}
