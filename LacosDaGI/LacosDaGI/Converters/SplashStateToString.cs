using LacosDaGI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace LacosDaGI.Converters
{
    public class SplashStateToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value.GetType() != typeof(SplashState))
                return "";

            var state = (SplashState)value;
            switch(state)
            {
                case SplashState.Initializing:
                    return "Inicializando o App...";
                case SplashState.LoadingDatabase:
                    return "Carregando o banco de dados...";
                case SplashState.LoadingResources:
                    return "Carregando recursos...";
                case SplashState.Loaded:
                    return "Carregado!";
                default:
                    return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
