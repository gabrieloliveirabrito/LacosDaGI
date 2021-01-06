using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace LacosDaGI.Converters
{
    public class BoolStateConverter : BaseConverter<bool, string>
    {
        public string TrueState { get; set; }
        public string FalseState { get; set; }

        public override string Convert(bool value, object parameter, CultureInfo culture)
        {
            return value ? TrueState : FalseState;
        }

        public override bool ConvertBack(string value, object parameter, CultureInfo culture)
        {
            return value == TrueState;
        }
    }
}