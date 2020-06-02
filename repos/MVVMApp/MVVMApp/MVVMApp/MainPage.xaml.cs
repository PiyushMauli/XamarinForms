using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            BindingContext = new PlaylistViewModel();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnAddPlaylist(object sender, System.EventArgs e)
        {
            (BindingContext as PlaylistViewModel).AddPlaylist();
        }

        void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            (BindingContext as PlaylistViewModel).SelectPlaylist(e.SelectedItem as PlaylistsViewModel);

            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
