using System;

namespace PropertiesEx
{

    public class Person
    {
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthday;
                int years = timespan.Days / 365;

                return years;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthday = new DateTime(1996, 3, 18);

            Console.WriteLine("Age is ", person.Age);
        }
    }
}
