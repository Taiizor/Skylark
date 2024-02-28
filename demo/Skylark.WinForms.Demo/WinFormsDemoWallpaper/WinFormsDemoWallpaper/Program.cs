﻿using System;
using System.Windows.Forms;

namespace WinFormsDemoWallpaper
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
#if NET6_0 || NET7_0 || NET8_0 || NET9_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Controller());
        }
    }
}