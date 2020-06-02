using System;

namespace HelloWorld
{
    class Program
    {
        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0} from {1}", to, Name);
            }

            public Person Parse(string str)
            {
                var per = new Person();
                per.Name = str;
                return per;
            }
        }

        static void Main(string[] args)
        {
            var person = new Person();
            var p=person.Parse("Piyush");
            p.Introduce("Dipika");
        }
    }
}
