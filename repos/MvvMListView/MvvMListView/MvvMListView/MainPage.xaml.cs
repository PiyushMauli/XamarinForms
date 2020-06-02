using MvvMListView.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvMListView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
         
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as MainPageViewModel;
            MobileList.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                MobileList.ItemsSource = _container.MobilePhones;
            else
                MobileList.ItemsSource = _container.MobilePhones.Where(i => i.Company.Contains(e.NewTextValue));

            MobileList.EndRefresh();
        }
    }
}
