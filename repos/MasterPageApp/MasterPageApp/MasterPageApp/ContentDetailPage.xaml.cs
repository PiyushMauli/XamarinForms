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
    public partial class ContentDetailPage : ContentPage
    {
		public ContentDetailPage(Contact contact)
		{
			if (contact == null)
				throw new ArgumentNullException();

			BindingContext = contact;

			InitializeComponent();
		}
	}
}