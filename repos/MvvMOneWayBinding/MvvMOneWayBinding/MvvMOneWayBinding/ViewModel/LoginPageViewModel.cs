using MvvMOneWayBinding.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvMOneWayBinding.ViewModel
{
    class LoginPageViewModel
    {
        private MyUser _myuser;

        public MyUser MyUser
        {
            get { return _myuser; }
            set { _myuser = value; }
        }
        public LoginPageViewModel()
        {
            MyUser = new MyUser()
            {
                UserName = "Piyush",
                Password = "xyz"
            };
        }
    }
}
