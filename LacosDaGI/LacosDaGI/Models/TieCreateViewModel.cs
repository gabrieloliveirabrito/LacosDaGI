using System;
using System.Collections.Generic;
using System.Text;

namespace LacosDaGI.Models
{
    public partial class TieCreateViewModel : BaseModel
    {
        public TieCreateViewModel()
        {
            InitializeMethods();
        }


        private bool _Editing;
        public bool Editing
        {
            get => _Editing;
            set => Set(ref _Editing, value);
        }

        private string _Name;
        public string Name
        {
            get => _Name;
            set => Set(ref _Name, value);
        }

        private byte[] _Image;
        public byte[] Image
        {
            get => _Image;
            set => Set(ref _Image, value);
        }

        private string _Description;
        public string Description
        {
            get => _Description;
            set => Set(ref _Description, value);
        }
    }
}
