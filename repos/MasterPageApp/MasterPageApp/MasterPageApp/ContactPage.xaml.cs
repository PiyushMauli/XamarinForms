using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterPageApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : MasterDetailPage
	{
		void listName_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var contact = e.SelectedItem as Contact;
			Detail = new NavigationPage(new ContentDetailPage(contact));
			IsPresented = false; // IsMasterPresented 
		}

		public ContactPage()
		{
			InitializeComponent();

			listName.ItemsSource = new List<Contact> {
				new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
				new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
			};
		}
	}
}