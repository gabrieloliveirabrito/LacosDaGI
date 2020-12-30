using LacosDaGI.DataModels;
using LacosDaGI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LacosDaGI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LacePreviewView : ContentPage
    {
        public Lace Lace { get; set; }

        public LacePreviewView(Lace lace)
        {
            InitializeComponent();

            Lace = lace;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            (BindingContext as LacePreviewModel).Lace = Lace;
        }
    }
}