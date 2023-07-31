using Microsoft.Win32;
using System.IO;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class WindowsStartupMachine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AppName"></param>
        /// <param name="AppPath"></param>
        /// <param name="Startup"></param>
        public static void SetStartup(string AppName, string AppPath, bool Startup)
        {
            SetStartupRegistry(AppName, AppPath, Startup);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AppName"></param>
        /// <param name="AppPath"></param>
        public static void ChangeStartup(string AppName, string AppPath)
        {
            SetStartupRegistry(AppName, AppPath, !GetStartupRegistry(AppName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Location"></param>
        /// <param name="Extension"></param>
        /// <returns></returns>
        private static string ChangeExtension(string Location, string Extension = ".exe")
        {
            return Path.ChangeExtension(Location, Extension);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AppName"></param>
        /// <param name="AppPath"></param>
        /// <param name="Startup"></param>
        private static void SetStartupRegistry(string AppName, string AppPath, bool Startup)
        {
            RegistryKey Key = GetRegistryKey(true);

            try
            {
                if (Startup)
                {
                    Key.SetValue(AppName, "\"" + ChangeExtension(AppPath, ".exe") + "\"");
                }
                else
                {
                    Key.DeleteValue(AppName, false);
                }
            }
            finally
            {
                Key.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AppName"></param>
        /// <returns></returns>
        private static bool GetStartupRegistry(string AppName)
        {
            RegistryKey Key = GetRegistryKey();

            try
            {
                return Key.GetValue(AppName) != null;
            }
            finally
            {
                Key.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Writable"></param>
        /// <returns></returns>
        private static RegistryKey GetRegistryKey(bool Writable = false)
        {
            return Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", Writable);
        }
    }
}