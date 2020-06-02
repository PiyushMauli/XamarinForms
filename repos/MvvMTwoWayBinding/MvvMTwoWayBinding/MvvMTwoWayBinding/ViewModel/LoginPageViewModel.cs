using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MvvMTwoWayBinding.ViewModel
{
    class LoginPageViewModel : INotifyPropertyChanged
    {
        string firstname, lastname, fullname;
        public string FirstName
        {
            get { return firstname; }
            set
            {
                if(firstname != value)
                {
                    firstname = value;
                    OnPropertyChanged("FirstName");
                                        
                }
            }
        }
        public string LastName
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    OnPropertyChanged("LastName");
                    
                }
            }
        }
        public string FullName
        {
            get { return fullname; }
            set
            {
                fullname = firstname + " " + lastname;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if(propertyName != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
