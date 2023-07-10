using Microsoft.Win32;
using System.IO;

namespace Skylark.Wing.Helper
{
    public static class WindowsStartupMachine
    {
        public static void SetStartup(string AppName, string AppPath, bool Startup)
        {
            SetStartupRegistry(AppName, AppPath, Startup);
        }

        public static void ChangeStartup(string AppName, string AppPath)
        {
            SetStartupRegistry(AppName, AppPath, !GetStartupRegistry(AppName));
        }

        private static string ChangeExtension(string Location, string Extension = ".exe")
        {
            return Path.ChangeExtension(Location, Extension);
        }

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

        private static RegistryKey GetRegistryKey(bool Writable = false)
        {
            return Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", Writable);
        }
    }
}
