using MvvMViewCell.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvvMViewCell.ViewModel
{
    class HomePageViewModel
    {
        public ObservableCollection<HomeDetails> HomeDetailCollections { get; set; }

        public HomePageViewModel()
        {
            HomeDetailCollections = new ObservableCollection<HomeDetails>()
            {
                new HomeDetails{Id=1,HomeName="Apple",HomeDetail="Best mobile company" },
                new HomeDetails{Id=2,HomeName="Oppo",HomeDetail="Worst mobile company" }
            };
        }
    }
}
