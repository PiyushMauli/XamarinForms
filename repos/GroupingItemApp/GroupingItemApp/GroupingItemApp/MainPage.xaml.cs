using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GroupingItemApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Contact> _contact;
        private void listName_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tabbed", contact.Name, "OK");
        }
        private void listName_SelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");
        }
        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = (sender as MenuItem).CommandParameter as Contact;
            DisplayAlert("Call", menuItem.Name, "OK");
        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            _contact.Remove(contact);
        }
        private void TextChanged_Handler(object sender, TextChangedEventArgs e)
        {
           listName.ItemsSource = GetContacts(e.NewTextValue);
        }
        private void List_Refresh(object sender, EventArgs e)
        {
            listName.ItemsSource = GetContacts();
            listName.IsPullToRefreshEnabled = false;
        }
        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contact =  new ObservableCollection<Contact>
            {
                new Contact{Name="iyush", Status="ingle"},
                new Contact { Name = "aurav", Status = "uch bhi nahi" }
            };
            if (string.IsNullOrWhiteSpace(searchText))
                return contact;

            return contact.Where(c => c.Name.StartsWith(searchText));
        }
        public MainPage()
        {
            InitializeComponent();

            _contact = new ObservableCollection<Contact>
            {
                new Contact{Name="Piyush", Status="Single"},
                new Contact { Name = "Gaurav", Status = "Kuch bhi nahi" }
            };

            listName.ItemsSource = _contact;
        }
        
    }
}
