using LacosDaGI.Dependencies;
using LacosDaGI.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LacosDaGI.Models
{
    public partial class SplashViewModel
    {
        public AsyncCommand<EventArgs> InitializeCommand { get; set; }
        public RelayCommand<EventArgs> ToMainPageCommand { get; set; }

        public void InitializeMethods()
        {
            InitializeCommand = new AsyncCommand<EventArgs>(Initialize);
            ToMainPageCommand = new RelayCommand<EventArgs>(ToMainPage);
        }

        private void ToMainPage(EventArgs obj)
        {
            Application.Current.MainPage = new NavigationPage(new MainView());
        }

        private async Task Initialize(EventArgs arg)
        {
            var darkColor = (Color)Application.Current.Resources["SecondaryDarkMainColor"];
            var lightColor = (Color)Application.Current.Resources["SecondaryLightMainColor"];

            StatusBar.SetStatusBarColor(Application.Current.RequestedTheme == OSAppTheme.Dark ? darkColor : lightColor);

            await Task.Delay(1500);
            State = SplashState.LoadingDatabase;
            await Task.Delay(1500);
            State = SplashState.LoadingResources;
            await Task.Delay(1500);
            State = SplashState.Loaded;
            await Task.Delay(1500);
        }
    }
}
