﻿using System;
using DatabaseDemo.Data;
using DatabaseDemo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatabaseDemo
{
    public partial class App : Application
    {
        static UserDatabaseController userDatabase;


        public App()
        {
            InitializeComponent();

             MainPage = new LoginPage();
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

        public static UserDatabaseController UserDatabase
        {
            get
            {
                if(userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }

    }
}
