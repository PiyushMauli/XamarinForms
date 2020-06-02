using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MvvMBasedDateTime.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            this.DateTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.DateTime = DateTime.Now;
                return true;
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;

        DateTime dateTime;

        public DateTime DateTime
        {
            get { return dateTime; }
            set
            {
                if(dateTime != value)
                {
                    dateTime = value;
                    if(PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
        }
    }
}
