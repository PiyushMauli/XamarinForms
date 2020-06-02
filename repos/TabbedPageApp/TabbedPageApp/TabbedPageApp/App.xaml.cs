using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage
            {
                Children = {
                    new MainPage(),new Page1(),new Page2()
                }
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
