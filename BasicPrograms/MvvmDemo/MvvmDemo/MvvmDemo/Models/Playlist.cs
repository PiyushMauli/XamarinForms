using MvvmDemo.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace MvvmDemo
{
    public class Playlist
    {
        public string Title { get; set; }

        private bool _isFavorite { get; set; }
    }
}
