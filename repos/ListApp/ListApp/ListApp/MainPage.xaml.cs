using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listName.ItemsSource = new List<Contact> { 
                new Contact{Name="Piyush Jiwane", ImageUrl="https://publicdomainvectors.org/tn_img/user3.png"},
                new Contact{Name="Gaurav Jiwane", ImageUrl="https://publicdomainvectors.org/tn_img/user2.png", Status="only calls, no whatsapp"},
            };
        }
    }
}
