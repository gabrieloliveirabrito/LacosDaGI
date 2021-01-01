using LacosDaGI.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LacosDaGI.Models
{
    public class TiePreviewModel : BaseModel
    {

        private Tie _Tie;
        public Tie Tie
        {
            get => _Tie;
            set => Set(ref _Tie, value);
        }
    }
}
