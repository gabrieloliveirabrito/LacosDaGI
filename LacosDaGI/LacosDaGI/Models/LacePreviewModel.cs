using LacosDaGI.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LacosDaGI.Models
{
    public class LacePreviewModel : BaseModel
    {
        private Tie _Lace;
        public Tie Lace
        {
            get => _Lace;
            set => Set(ref _Lace, value);
        }
    }
}
