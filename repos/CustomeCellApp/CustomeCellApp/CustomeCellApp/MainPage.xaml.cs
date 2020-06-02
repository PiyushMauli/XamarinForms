using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomeCellApp
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
                        new Contact{Name="Piyush Jiwane", ImageUrl = "arrow.png" , Status="Single"},
                        new Contact{Name="Gaurav Jiwane", ImageUrl = "arrow1.png" ,  Status="only calls, no whatsapp"},
                };
        }

    }
}
