using System;
using System.Collections.Generic;
using System.Text;

namespace LacosDaGI.Dependencies
{
    public abstract class Paths : BaseDependency<Paths>
    {
        public abstract string DBPath { get; }

        public static string DbPath
        {
            get => Dependency.DBPath;
        }
    }
}
