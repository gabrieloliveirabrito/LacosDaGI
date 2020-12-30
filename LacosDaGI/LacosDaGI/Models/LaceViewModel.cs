using LacosDaGI.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LacosDaGI.Models
{
    public partial class LaceViewModel : BaseModel
    {
        public LaceViewModel()
        {
            InitializeMethods();
        }

        private Lace[] _Laces;
        public Lace[] Laces
        {
            get => _Laces;
            set => Set(ref _Laces, value);
        }
    }
}
