using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace LacosDaGI.Converters
{
    public class BufferToImage : BaseConverter<byte[], ImageSource>
    {
        public override ImageSource Convert(byte[] value, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            return ImageSource.FromStream(() => new MemoryStream(value));
        }

        public override byte[] ConvertBack(ImageSource value, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
