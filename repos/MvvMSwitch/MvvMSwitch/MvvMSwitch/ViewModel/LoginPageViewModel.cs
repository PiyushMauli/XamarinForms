using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MvvMSwitch.ViewModel
{
    class LoginPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        string personname;
        public string PersonName
        {
            get { return personname; }
            set
            {
                personname = value;
                OnPropertyChanged("PersonName");
                OnPropertyChanged(ShowMessage);
            }
        }
        string worksin;
        public string WorksIn
        {
            get { return worksin; }
            set
            {
                worksin = value;
                OnPropertyChanged("WorksIn");
                OnPropertyChanged(ShowMessage);
            }
        }
        bool myswith;

        public bool MySwitch
        {
            get { return myswith; }
            set
            {
                myswith = value;
                OnPropertyChanged("MySwitch");
                OnPropertyChanged(ShowMessage);
            }
        }
        public string ShowMessage
        {
            get { return PersonName + " " + WorksIn + " " + MySwitch; }
        }
    }
}
