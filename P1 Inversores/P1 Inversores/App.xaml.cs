﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1_Inversores
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }
//Esta modificacion la hizo Martin
        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
