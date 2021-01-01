using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(LacosDaGI.Droid.Dependencies.Paths))]
namespace LacosDaGI.Droid.Dependencies
{
    public class Paths : LacosDaGI.Dependencies.Paths
    {
        public override string DBPath
        {
            get => Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "lacos.db");
        }
    }
}