using MvvMListSearch.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvMListSearch.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListPage : ContentPage
    {
        public MyListPage()
        {
            InitializeComponent();

            BindingContext = new MyListViewModel();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var container = BindingContext as MyListViewModel;
            EmployeeListView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                EmployeeListView.ItemsSource = container.MyListCollector;

            else
                EmployeeListView.ItemsSource = container.MyListCollector.Where(c => c.Company.ToLower().Contains(e.NewTextValue.ToLower()));

            EmployeeListView.EndRefresh();

        }
    }
}