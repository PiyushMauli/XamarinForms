using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DialerApp
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
        private void KeyPad(object sender, EventArgs e)
        {
            string keypadValue = keypad.Text;
            int strLength = keypadValue.Length;
            if (strLength < 10)
            {
                keypad.Text = keypadValue + (sender as Button).Text;
            }
            
        }
    }
}
