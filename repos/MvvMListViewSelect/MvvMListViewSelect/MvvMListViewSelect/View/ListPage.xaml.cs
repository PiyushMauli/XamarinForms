using MvvMListViewSelect.Model;
using MvvMListViewSelect.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvMListViewSelect.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            BindingContext = new ListPageViewModel();
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var foodDetails = e.Item as MyFoodList;
            await Navigation.PushAsync(new ListPagedetails(foodDetails));

            ((ListView)sender).SelectedItem = null;
        }
    }
}