using MvvMEntryButton.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvMEntryButton.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            BindingContext = new LoginPageViewModel();

            LoginBtn.Clicked += LoginButton_Clicked;
        }

        async void LoginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DashboardPage());
        }
    }
}