using LacosDaGI.DataModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace LacosDaGI.Models
{
    public partial class TieViewModel : BaseModel
    {
        public TieViewModel()
        {
            InitializeMethods();
            Laces = new ObservableCollection<Tie>();
        }


        private ObservableCollection<Tie> _Laces;
        public ObservableCollection<Tie> Laces
        {
            get => _Laces;
            set => Set(ref _Laces, value);
        }
    }
}
