using MvvMListViewSelect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvMListViewSelect.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPagedetails : ContentPage
    {
        public ListPagedetails(MyFoodList obj)
        {
            InitializeComponent();

            BurgerName.Text = obj.Name;

            BurgerDetails.Text = obj.Details;
        }
    }
}