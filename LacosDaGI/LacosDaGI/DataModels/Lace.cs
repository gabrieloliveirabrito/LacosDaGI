using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace LacosDaGI.DataModels
{
    public class Lace
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private string _image;
        public string Image
        {
            get { return _image; }
            set 
            { 
                _image = value; 
                try
                {
                    var data = Convert.FromBase64String(value);
                    ImageSource = ImageSource.FromStream(() => new System.IO.MemoryStream(data));
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        public ImageSource ImageSource
        {
            get;private set;
        }
    }
}
