using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LacosDaGI.Models
{
    public partial class MainViewModel
    {
        public AsyncCommand<Type> NavigateToCommand { get; set; }

        protected void InitializeMethods()
        {
            NavigateToCommand = new AsyncCommand<Type>(NavigateTo);
        }

        private async Task NavigateTo(Type to)
        {
            if (to.BaseType == typeof(ContentPage))
            {
                var page = (Page)Activator.CreateInstance(to);
                await Application.Current.MainPage.Navigation.PushAsync(page);
            }
        }
    }
}
