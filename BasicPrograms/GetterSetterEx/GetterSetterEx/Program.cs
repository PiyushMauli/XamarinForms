using System;

namespace GetterSetterEx
{
    public class Demo
    {
        public Demo(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate { get; private set; }
        public int Age
        {
            get
            {
                var yearDiff = DateTime.Today - Birthdate;
                var years = yearDiff.Days / 365;

                return years;
            }
        }
    }

    class Program
    {
        
    }
}
