using MvvMListViewSelect.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvvMListViewSelect.ViewModel
{
    class ListPageViewModel
    {
        public ObservableCollection<MyFoodList> FoodList { get; set; }
        public ListPageViewModel()
        {
            FoodList = new ObservableCollection<MyFoodList>()
            {
                new MyFoodList{Id=1,Name="",Details="From Dominos"},
                new MyFoodList{Id=2,Name="Fried Chicken",Details="From KFC"}
            };
        }
    }
}
