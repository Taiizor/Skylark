using Microsoft.Win32;
using System.Diagnostics;
using System.Text;
using SWNM = Skylark.Wing.Native.Methods;
using SWUD = Skylark.Wing.Utility.Desktop;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class BackgroundImage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MaxChars"></param>
        /// <returns></returns>
        public static string GetPathSystemParameters(int MaxChars = 256)
        {
            try
            {
                StringBuilder WallpaperPath = new(MaxChars);

                if (SWNM.SystemParametersInfo((int)SWNM.SPI.SPI_GETDESKWALLPAPER, (uint)WallpaperPath.Capacity, WallpaperPath, 0))
                {
                    string Value = WallpaperPath.ToString();

                    if (string.IsNullOrWhiteSpace(Value))
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return Value;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Refresh"></param>
        /// <returns></returns>
        public static bool SetPathSystemParameters(string Path = "", bool Refresh = true)
        {
            try
            {
                if (SWNM.SystemParametersInfo((int)SWNM.SPI.SPI_SETDESKWALLPAPER, 0, Path, SWNM.SPIF_UPDATEINIFILE | SWNM.SPIF_SENDWININICHANGE))
                {
                    if (Refresh)
                    {
                        SWUD.RefreshDesktop();
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubKey"></param>
        /// <param name="SubValue"></param>
        /// <returns></returns>
        public static string GetPathRegistry(string SubKey = @"Control Panel\Desktop", string SubValue = "Wallpaper")
        {
            RegistryKey Key = GetRegistryKey(SubKey);

            try
            {
                string Value = Key.GetValue(SubValue).ToString();

                if (string.IsNullOrWhiteSpace(Value))
                {
                    return string.Empty;
                }
                else
                {
                    return Value;
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
        /// <param name="SubKey"></param>
        /// <param name="SubValue"></param>
        /// <returns></returns>
        public static string GetTileRegistry(string SubKey = @"Control Panel\Desktop", string SubValue = "TileWallpaper")
        {
            RegistryKey Key = GetRegistryKey(SubKey);

            try
            {
                string Value = Key.GetValue(SubValue).ToString();

                if (string.IsNullOrWhiteSpace(Value))
                {
                    return string.Empty;
                }
                else
                {
                    return Value;
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
        /// <param name="SubKey"></param>
        /// <param name="SubValue"></param>
        /// <returns></returns>
        public static string GetStyleRegistry(string SubKey = @"Control Panel\Desktop", string SubValue = "WallpaperStyle")
        {
            RegistryKey Key = GetRegistryKey(SubKey);

            try
            {
                string Value = Key.GetValue(SubValue).ToString();

                if (string.IsNullOrWhiteSpace(Value))
                {
                    return string.Empty;
                }
                else
                {
                    return Value;
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
        /// <param name="SubKey"></param>
        /// <param name="SubValue"></param>
        /// <param name="Path"></param>
        /// <param name="Refresh"></param>
        /// <returns></returns>
        public static bool SetPathRegistry(string SubKey = @"Control Panel\Desktop", string SubValue = "Wallpaper", string Path = "", bool Refresh = true)
        {
            RegistryKey Key = GetRegistryKey(SubKey, true);

            try
            {
                Key.SetValue(SubValue, Path);

                if (Refresh)
                {
                    SWUD.RefreshDesktop();
                }

                return true;
            }
            finally
            {
                Key.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubKey"></param>
        /// <param name="SubValue"></param>
        /// <param name="Tile"></param>
        /// <param name="Refresh"></param>
        /// <returns></returns>
        public static bool SetTileRegistry(string SubKey = @"Control Panel\Desktop", string SubValue = "TileWallpaper", string Tile = "0", bool Refresh = true)
        {
            RegistryKey Key = GetRegistryKey(SubKey, true);

            try
            {
                Key.SetValue(SubValue, Tile);

                if (Refresh)
                {
                    SWUD.RefreshDesktop();
                }

                return true;
            }
            finally
            {
                Key.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubKey"></param>
        /// <param name="SubValue"></param>
        /// <param name="Style"></param>
        /// <param name="Refresh"></param>
        /// <returns></returns>
        public static bool SetStyleRegistry(string SubKey = @"Control Panel\Desktop", string SubValue = "WallpaperStyle", string Style = "10", bool Refresh = true)
        {
            RegistryKey Key = GetRegistryKey(SubKey, true);

            try
            {
                Key.SetValue(SubValue, Style);

                if (Refresh)
                {
                    SWUD.RefreshDesktop();
                }

                return true;
            }
            finally
            {
                Key.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Command"></param>
        /// <returns></returns>
        public static string GetPathPowerShell(string FileName = "powershell", string Command = "-Command \"(Get-ItemProperty -Path 'HKCU:\\Control Panel\\Desktop\\' -Name Wallpaper).Wallpaper\"")
        {
            try
            {
                using Process Process = new();

                Process.StartInfo.Arguments = Command;
                Process.StartInfo.FileName = FileName;
                Process.StartInfo.CreateNoWindow = true;
                Process.StartInfo.UseShellExecute = false;
                Process.StartInfo.RedirectStandardOutput = true;

                Process.Start();

                string Value = Process.StandardOutput.ReadToEnd().Trim();

                Process.WaitForExit();

                if (string.IsNullOrWhiteSpace(Value))
                {
                    return string.Empty;
                }
                else
                {
                    return Value;
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Command"></param>
        /// <returns></returns>
        public static string GetTilePowerShell(string FileName = "powershell", string Command = "-Command \"(Get-ItemProperty -Path 'HKCU:\\Control Panel\\Desktop\\' -Name TileWallpaper).TileWallpaper\"")
        {
            try
            {
                using Process Process = new();

                Process.StartInfo.Arguments = Command;
                Process.StartInfo.FileName = FileName;
                Process.StartInfo.CreateNoWindow = true;
                Process.StartInfo.UseShellExecute = false;
                Process.StartInfo.RedirectStandardOutput = true;

                Process.Start();

                string Value = Process.StandardOutput.ReadToEnd().Trim();

                Process.WaitForExit();

                if (string.IsNullOrWhiteSpace(Value))
                {
                    return string.Empty;
                }
                else
                {
                    return Value;
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Command"></param>
        /// <returns></returns>
        public static string GetStylePowerShell(string FileName = "powershell", string Command = "-Command \"(Get-ItemProperty -Path 'HKCU:\\Control Panel\\Desktop\\' -Name WallpaperStyle).WallpaperStyle\"")
        {
            try
            {
                using Process Process = new();

                Process.StartInfo.Arguments = Command;
                Process.StartInfo.FileName = FileName;
                Process.StartInfo.CreateNoWindow = true;
                Process.StartInfo.UseShellExecute = false;
                Process.StartInfo.RedirectStandardOutput = true;

                Process.Start();

                string Value = Process.StandardOutput.ReadToEnd().Trim();

                Process.WaitForExit();

                if (string.IsNullOrWhiteSpace(Value))
                {
                    return string.Empty;
                }
                else
                {
                    return Value;
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Command"></param>
        /// <param name="Path"></param>
        /// <param name="Refresh"></param>
        /// <returns></returns>
        public static bool SetPathPowerShell(string FileName = "powershell", string Command = "Set-ItemProperty -Path 'HKCU:\\Control Panel\\Desktop' -Name Wallpaper '{0}'", string Path = "", bool Refresh = true)
        {
            try
            {
                using Process Process = new();

                Process.StartInfo.FileName = FileName;
                Process.StartInfo.CreateNoWindow = true;
                Process.StartInfo.UseShellExecute = false;
                Process.StartInfo.Arguments = string.Format(Command, Path);

                Process.Start();

                Process.WaitForExit();

                if (Refresh)
                {
                    SWUD.RefreshDesktop();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Command"></param>
        /// <param name="Tile"></param>
        /// <param name="Refresh"></param>
        /// <returns></returns>
        public static bool SetTilePowerShell(string FileName = "powershell", string Command = "Set-ItemProperty -Path 'HKCU:\\Control Panel\\Desktop' -Name TileWallpaper '{0}'", string Tile = "0", bool Refresh = true)
        {
            try
            {
                using Process Process = new();

                Process.StartInfo.FileName = FileName;
                Process.StartInfo.CreateNoWindow = true;
                Process.StartInfo.UseShellExecute = false;
                Process.StartInfo.Arguments = string.Format(Command, Tile);

                Process.Start();

                Process.WaitForExit();

                if (Refresh)
                {
                    SWUD.RefreshDesktop();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Command"></param>
        /// <param name="Style"></param>
        /// <param name="Refresh"></param>
        /// <returns></returns>
        public static bool SetStylePowerShell(string FileName = "powershell", string Command = "Set-ItemProperty -Path 'HKCU:\\Control Panel\\Desktop' -Name WallpaperStyle '{0}'", string Style = "10", bool Refresh = true)
        {
            try
            {
                using Process Process = new();

                Process.StartInfo.FileName = FileName;
                Process.StartInfo.CreateNoWindow = true;
                Process.StartInfo.UseShellExecute = false;
                Process.StartInfo.Arguments = string.Format(Command, Style);

                Process.Start();

                Process.WaitForExit();

                if (Refresh)
                {
                    SWUD.RefreshDesktop();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Writable"></param>
        /// <returns></returns>
        private static RegistryKey GetRegistryKey(string Key, bool Writable = false)
        {
            return Registry.CurrentUser.OpenSubKey(Key, Writable);
        }
    }
}