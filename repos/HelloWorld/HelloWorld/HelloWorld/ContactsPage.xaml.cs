using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class ContactsPage : MasterDetailPage
	{
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{

			var contact = e.SelectedItem as Contact;
			Detail = new NavigationPage(new ContactDetailPage(contact));
			IsPresented = false; // IsMasterPresented
		}

		public ContactsPage()
		{
			InitializeComponent();

			listView.ItemsSource = new List<Contact> {
				new Contact { Name = "Piyush Jiwane", ImageUrl = "http://lorempixel.com/100/100/people/1", Status="Single"},
				new Contact { Name = "Mauli", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
			};
		}
	}
}
