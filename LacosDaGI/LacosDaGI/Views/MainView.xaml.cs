using LacosDaGI.Dependencies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LacosDaGI.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
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

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
