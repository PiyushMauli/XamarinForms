using MvvMListSearch.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvvMListSearch.ViewModel
{
    public class MyListViewModel
    {
        public ObservableCollection<MyListModel> MyListCollector { get; set; }

        public MyListViewModel()
        {
            MyListCollector = new ObservableCollection<MyListModel>()
            {
                new MyListModel(){Company="Samsung"},
                new MyListModel(){Company="Apple"},
                new MyListModel(){Company="Mi"},
                new MyListModel(){Company="Vivo"},
                new MyListModel(){Company="Oppo"},
                new MyListModel(){Company="Nokia"}
            };
        }
    }
}
