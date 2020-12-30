using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace LacosDaGI.Converters
{
    public class Base64ToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value.GetType() != typeof(string))
                throw new InvalidCastException();

            var data = System.Convert.FromBase64String(value.ToString());
            return ImageSource.FromStream(() => new MemoryStream(data));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
