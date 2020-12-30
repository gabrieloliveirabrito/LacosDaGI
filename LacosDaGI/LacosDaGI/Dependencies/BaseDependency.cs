using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LacosDaGI.Dependencies
{
    public abstract class BaseDependency<T>
        where T : BaseDependency<T>
    {
        public static T Dependency => DependencyService.Get<T>();
    }
}
