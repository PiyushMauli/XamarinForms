using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FontSizeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private int index = 0;
        private string[] quotes = new string[] {
            "The most important thing is to try and inspire people so that they can be great in whatever they want to do",
            "Yesterday is not ours to recover, but tomorrow is ours to win or lose",
            "Keep your face to the sunshine and you cannot see a shadow"
        };

        public MainPage()
        {
            InitializeComponent();
            inputValue.Text = quotes[index];
        }

        private void Changed_Text(object sender, EventArgs e)
        {
            index++;
            if (index >= quotes.Length)
                index = 0;

            inputValue.Text = quotes[index];
        }
    }
}
