using LacosDaGI.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LacosDaGI.Models
{
    public class LacePreviewModel : BaseModel
    {
        private Lace _Lace;
        public Lace Lace
        {
            get => _Lace;
            set => Set(ref _Lace, value);
        }
    }
}
