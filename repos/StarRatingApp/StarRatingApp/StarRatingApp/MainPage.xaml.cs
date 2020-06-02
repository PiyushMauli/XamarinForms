using Syncfusion.SfRating.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace StarRatingApp
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

        private void rating_ValueChanged(object sender, ValueEventArgs e)
        {
            var ratingValue = e.Value;
            switch (ratingValue)
            {
                case 1:
                    ratingImage.Source = "smiley1.png";
                    break;
                case 2:
                    ratingImage.Source = "smiley2.png";
                    break;
                case 3:
                    ratingImage.Source = "smiley3.png";
                    break;
                case 4:
                    ratingImage.Source = "smiley4.png";
                    break;
                case 5:
                    ratingImage.Source = "smiley5.png";
                    Device.OpenUri(new Uri("market://details?id=com.impelsys.academy"));
                    break;
            }
        }

        
    }
}
