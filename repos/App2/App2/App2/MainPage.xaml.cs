using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Details(object sender, EventArgs e) {
            var date = dp.Date;
            var time = tp.Time;
            var localtion = MyPicker.SelectedItem;
            details.Text = string.Format("Date : {0} \nTime : {1} \nLocation : {2}", date, time, localtion);
        }
    }
}
