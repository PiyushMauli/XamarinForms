using System;

namespace CompotionDemov2
{
    class Program
    {
        public class Logging
        {
            public void Log(string msg)
            {
                Console.WriteLine(msg);
            }
        }

        public class Login
        {
            private readonly Logging _log;
            public Login(Logging log)
            {
                this._log = log;
            }
            public void LoginInfo(string msg)
            {
                _log.Log(msg);
            }
        }

        public class Registration
        {
            private readonly Logging _log;
            public Registration(Logging log)
            {
                this._log = log;
            }
            public void RegistrationInfo(string msg)
            {
                _log.Log(msg);
            }
        }
        static void Main(string[] args)
        {
            var login = new Login(new Logging());
            login.LoginInfo("Hello from Login class");

            var registration = new Registration(new Logging());
            registration.RegistrationInfo("Hello from Registration class");
        }
    }
}
