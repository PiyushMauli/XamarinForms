using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WindowsAPP
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            int enteredNum = Convert.ToInt32(guessNumber.Text);
            if (enteredNum < 10)
            {
                Random r = new Random();
                int num = r.Next(10);
                if (num == enteredNum)
                {
                    checkNum.Text = "Congratulations !!! Your guess the correct Number";
                    checkNum.TextColor = Color.Green;
                    checkNum.IsVisible = true;

                }
                else
                {
                    checkNum.Text = String.Format("Sorry !!! Your guess was incorrect. Please try again. Your Number is {0}", num);
                    checkNum.TextColor = Color.Red;
                    checkNum.IsVisible = true;
                }
            }
            else
            {
                checkNum.Text = "You have entered a number greater than 10";
                checkNum.TextColor = Color.Blue;
                checkNum.IsVisible = true;
            }
        }
    }
}
