﻿using MvvMListSearch.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvMListSearch
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyListPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
