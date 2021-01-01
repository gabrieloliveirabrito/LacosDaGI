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
    public partial class TiePreviewView : ContentPage
    {
        public Tie Tie { get; set; }

        public TiePreviewView(Tie tie)
        {
            InitializeComponent();

            Tie = tie;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            (BindingContext as TiePreviewModel).Tie = Tie;
        }
    }
}