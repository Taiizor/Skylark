using System;

namespace Skylark.WallpaperEngine
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            _ = new CS.Engine();
        }
    }
}