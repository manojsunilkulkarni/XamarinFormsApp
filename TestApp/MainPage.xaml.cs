﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
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

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.LimeGreen;
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Yellow;
        }
    }

}
