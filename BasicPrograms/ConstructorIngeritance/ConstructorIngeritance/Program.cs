using System;

namespace ConstructorIngeritance
{
    public class Vehicle
    {
        private string _registrationNumber;
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine(_registrationNumber);
        }
    }
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("From Car class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("MH AP2823");
            
        }
    }
}
