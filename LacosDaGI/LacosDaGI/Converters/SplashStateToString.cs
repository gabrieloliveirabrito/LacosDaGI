using LacosDaGI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace LacosDaGI.Converters
{
    public class SplashStateToString : BaseConverter<SplashState, string>
    {
        public override string Convert(SplashState value, object parameter, CultureInfo culture)
        {
            switch (value)
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

        public override SplashState ConvertBack(string value, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
