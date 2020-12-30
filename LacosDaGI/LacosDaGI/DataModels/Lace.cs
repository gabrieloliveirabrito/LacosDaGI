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
            }
        }

        public ImageSource ImageSource
        {
            get;private set;
        }
    }
}
