using System;

namespace compositionDemo
{
    public class Information
    {
        public string Email { get; set; }
    }

    public class Login
    {
        private readonly Information _info;
        public Login(Information info)
        {
            this._info = info;
        }
        public void LoginInfo(string email)
        {
            _info.Email = email;
        }
        public string RLoginInfo()
        {
            return _info.Email;
        }
    }

    public class Registration
    {
        private readonly Information _info;
        public Registration(Information info)
        {
            this._info = info;
        }
        public void RegistrationInfo(string email)
        {
            _info.Email = email;
        }
        public string RRegistrationInfo()
        {
            return _info.Email;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var login = new Login(new Information());
            login.LoginInfo("Jiwnaepiyush@gmail.com");
            Console.WriteLine("from Login {0}",login.RLoginInfo());

            var registration = new Registration(new Information());
            registration.RegistrationInfo("piyush.j@impelsys.com");
            Console.WriteLine("form registration {0}",registration.RRegistrationInfo());
        }
    }
}
