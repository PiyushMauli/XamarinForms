using MvvMEntryButton.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvMEntryButton.ViewModel
{
    class LoginPageViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { get; private set; }
        public LoginPageViewModel()
        {
            LoginCommand = new Command(async () => await LogUser());
        }

        async Task LogUser()
        {
            await App.Current.MainPage.Navigation.PushAsync(new DashboardPage());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        string user;
        public string User
        {
            get { return user; }
            set
            {
                if (user != value)
                {
                    user = value;
                    OnPropertyChanged();
                }
            }
        }
        string pass;

        public string Pass
        {
            get { return pass; }
            set
            {
                if (pass != value)
                {
                    pass = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
