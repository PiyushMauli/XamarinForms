using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MVVMApp
{
    public class PlaylistViewModel : BaseViewModel 
    {
        public ObservableCollection<PlaylistsViewModel> Playlists { get; private set; } = new ObservableCollection<PlaylistsViewModel>();

        private PlaylistsViewModel _selectedPlaylist;
        public PlaylistsViewModel SelectedPlaylist
        {
            get { return _selectedPlaylist; }
            set
            {
                SetValue(ref _selectedPlaylist, value);
            }
        }

        public void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);

            Playlists.Add(new PlaylistsViewModel { Title = newPlaylist });
        }

        public void SelectPlaylist(PlaylistsViewModel playlist)
        {
            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;
        }
    }
}
