using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LacosDaGI.Dependencies
{
    public abstract class StatusBar : BaseDependency<StatusBar>
    {
        protected abstract void ChangeStatusBarColor(Color color);

        public static void SetStatusBarColor(Color color)
        {
            Dependency.ChangeStatusBarColor(color);
        }
    }
}
