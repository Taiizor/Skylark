using Skylark.WallpaperEngine.UI;
using System;
using System.Threading;
using System.Windows.Forms;
using static Skylark.WallpaperEngine.CS.Setting;

namespace Skylark.WallpaperEngine.CS
{
    public class Engine
    {
        private static readonly Mutex MTX = new(true, "{Skylark Wallpaper Engine - New Generation Wallpaper Engine}");

        public Engine()
        {
            try
            {
                Application.EnableVisualStyles();
#if NET6_0 || NET7_0 || NET8_0
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
                Application.SetCompatibleTextRenderingDefault(false);
                if (MTX.WaitOne(TimeSpan.Zero, true))
                {
                    MTX.ReleaseMutex();
                    _ = new Setting(ConfigFileName);
                    Control.CheckForIllegalCrossThreadCalls = false;
                    Application.Run(new Main());
                }
                else
                {
                    MessageBox.Show("Already Open!", "Skylark Wallpaper Engine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\n" + Ex.StackTrace);
            }
        }
    }
}