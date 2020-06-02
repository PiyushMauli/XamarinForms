using MvvMListView.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvvMListView.ViewModel
{
    class MainPageViewModel
    {
        public ObservableCollection<Mobile> MobilePhones { get; set; }

        public MainPageViewModel()
        {
            MobilePhones = new ObservableCollection<Mobile>()
            {
                new Mobile{Company="Samsung"},
                new Mobile{Company="Mi"},
                new Mobile{Company="Oppo"},
                new Mobile{Company="Vivo"},
                new Mobile{Company="Nokia"},
                new Mobile{Company="Apple"}
            };


        }
    }
}
