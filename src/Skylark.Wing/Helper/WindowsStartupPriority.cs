using Microsoft.Win32;
using System.IO;

namespace Skylark.Wing.Helper
{
    public static class WindowsStartupPriority
    {
        public static void SetStartup(string AppPath, bool Startup)
        {
            SetStartupRegistry(AppPath, Startup);
        }

        public static void ChangeStartup(string AppPath)
        {
            SetStartupRegistry(AppPath, !GetStartupRegistry(AppPath));
        }

        private static string ChangeExtension(string Location, string Extension = ".exe")
        {
            return Path.ChangeExtension(Location, Extension);
        }

        private static void SetStartupRegistry(string AppPath, bool Startup)
        {
            RegistryKey Key = GetRegistryKey(true);

            try
            {
                string Value = Key.GetValue("Userinit").ToString();

                if (Startup && !GetStartupRegistry(AppPath))
                {
                    if (!Value.EndsWith(",") && !string.IsNullOrEmpty(Value))
                    {
                        Value += ",";
                    }

                    Key.SetValue("Userinit", Value + ChangeExtension(AppPath, ".exe") + ",");
                }
                else if (!Startup && GetStartupRegistry(AppPath))
                {
                    if (Value.EndsWith(","))
                    {
                        Value = Value.Replace(AppPath + ",", "");
                    }
                    else
                    {
                        Value = Value.Replace(AppPath, "");
                    }

                    Key.SetValue("Userinit", Value);
                }
            }
            finally
            {
                Key.Close();
            }
        }

        private static bool GetStartupRegistry(string AppPath)
        {
            RegistryKey Key = GetRegistryKey();

            try
            {
                return Key.GetValue("Userinit").ToString().Contains(AppPath);
            }
            finally
            {
                Key.Close();
            }
        }

        private static RegistryKey GetRegistryKey(bool Writable = false)
        {
            return Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Winlogon", Writable);
        }
    }
}
