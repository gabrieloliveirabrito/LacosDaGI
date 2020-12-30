using System;
using System.Collections.Generic;
using System.Text;

namespace LacosDaGI.Models
{
    public enum SplashState
    {
        Initializing,
        LoadingDatabase,
        LoadingResources,
        Loaded
    }

    public partial class SplashViewModel : BaseModel
    {
        public SplashViewModel()
        {
            InitializeMethods();
            State = SplashState.Initializing;
        }

        private SplashState _Loaded;
        public SplashState State
        {
            get => _Loaded;
            set => Set(ref _Loaded, value);
        }
    }
}
