using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HierarchicalApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomeApp : ContentPage
    {
        public WelcomeApp()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new IntroductionApp());
        }
    }
}