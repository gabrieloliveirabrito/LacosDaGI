using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:Dependency(typeof(LacosDaGI.Droid.Dependencies.StatusBar))]
namespace LacosDaGI.Droid.Dependencies
{
    public class StatusBar : LacosDaGI.Dependencies.StatusBar
    {
        protected override void ChangeStatusBarColor(Color color)
        {
            var activity = CrossCurrentActivity.Current.Activity;

            activity.Window.SetStatusBarColor(color.ToAndroid());
        }
    }
}