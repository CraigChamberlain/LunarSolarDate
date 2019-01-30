﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SolarLunarName.Forms
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            MainPage = new MainPage();

        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps

            //Connections are owned by pool.  
            //This will dispose of any open connections
            SQLiteAsyncConnection.ResetPool();
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}
