using System;

namespace EnumProgram
{
    class Program
    {
        public enum Days
        {
            MONDAY = 1,
            TUESDAY = 11,
            WEDNESDAY = 21,
            THURSDAY,
            FRIDAY,
        }
        static void Main(string[] args)
        {
            var days = Days.FRIDAY;
            Console.WriteLine((int)days);

            foreach (int item in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine((Days)item);
            }

            foreach (var item in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine(Enum.GetName(typeof(Days), 21));
        }
    }
}
