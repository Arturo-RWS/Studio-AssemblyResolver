using System;
using System.IO;

namespace Rws.StudioAssemblyResolver.PathResolver.Implementation
{
    public class DefaultStudio2026PathResolver : IPathResolver
    {
        public string Resolve() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"Trados\Trados Studio\Studio19\");
    }
}
