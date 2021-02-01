using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LacosDaGI.Views.Main
{
    using Dependencies;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;
            Current_RequestedThemeChanged(this, new AppThemeChangedEventArgs(Application.Current.RequestedTheme));
        }

        private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            var darkColor = (Color)Application.Current.Resources["SecondaryDarkMainColor"];
            var lightColor = (Color)Application.Current.Resources["SecondaryLightMainColor"];

            StatusBar.SetStatusBarColor(e.RequestedTheme == OSAppTheme.Dark ? darkColor : lightColor);
        }
    }
}
