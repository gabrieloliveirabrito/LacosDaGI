using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace LacosDaGI.Converters
{
    public class Base64ToImage : BaseConverter<string, ImageSource>
    {
        public override ImageSource Convert(string value, object parameter, CultureInfo culture)
        {
            var data = System.Convert.FromBase64String(value);
            return ImageSource.FromStream(() => new MemoryStream(data));
        }

        public override string ConvertBack(ImageSource value, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
