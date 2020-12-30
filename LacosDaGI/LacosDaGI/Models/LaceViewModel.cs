using LacosDaGI.DataModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace LacosDaGI.Models
{
    public partial class LaceViewModel : BaseModel
    {
        public LaceViewModel()
        {
            InitializeMethods();
            Laces = new ObservableCollection<Lace>();
        }

       public ObservableCollection<Lace> Laces { get; set; }
    }
}
