using MvvmDemo.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MvvmDemo
{
    public partial class PlaylistsPage : ContentPage
    {

        public PlaylistsPage ()
        {
            BindingContext = new PlaylistsViewModel();
            InitializeComponent ();
        }

        protected override void OnAppearing ()
        { 
            base.OnAppearing ();
        }

        void OnAddPlaylist (object sender, System.EventArgs e)
        {
            (BindingContext as PlaylistsViewModel).AddPlaylist();
        }

        void OnPlaylistSelected (object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            (BindingContext as PlaylistsViewModel).SelectPlaylist(e.SelectedItem as Playlist);
        }
    }
}
