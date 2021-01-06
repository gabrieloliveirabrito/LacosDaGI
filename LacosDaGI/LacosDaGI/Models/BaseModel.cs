using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LacosDaGI.Models
{
    public abstract class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation
        {
            get => App.Current.MainPage.Navigation;
        }

        protected virtual void Set<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (field == null && value != null || field != null && !field.Equals(value))
            {
                field = value;
                NotifyChanged(propertyName);
            }
        }

        protected void NotifyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void NotifyAll() => NotifyChanged("");

        protected async Task ShowDialog(string title, string message, string close = "OK")
        {
            await App.Current.MainPage.DisplayAlert(title, message, close);
        }

        protected async Task<bool> ShowConfirmDialog(string title, string message, string accept = "Sim", string cancel = "Não")
        {
            return await App.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }
    }
}
