using Skylark.Helper;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Skylark.UI
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Culture.All = new CultureInfo("en-GB");
            Application.EnableVisualStyles();
#if NETCOREAPP3_1 || NET6_0 || NET7_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}