#region Imports

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using SELFT = Skylark.Enum.LockScreenFitType;
using SWHLC = Skylark.Wing.Helper.LockScreenCache;
using SWMLC = Skylark.Wing.Model.LockScreenConfigModel;

#endregion

namespace Skylark.Wing.Manage
{
    /// <summary>
    /// Manager for Windows Lock Screen Live Wallpaper settings, cache generation, and native credential provider.
    /// </summary>
    public static class LockScreen
    {
        #region Constants

        /// <summary>
        /// Default CLSID for the Lock Screen Credential Provider.
        /// </summary>
        public const string ProviderCLSID = "{7C4B13B8-439D-4F18-A7F0-18DCEE32A001}";

        /// <summary>
        /// Display name for the Credential Provider.
        /// </summary>
        public const string ProviderDisplayName = "Lock Screen Live Wallpaper Provider";

        #endregion

        #region Properties & Paths

        /// <summary>
        /// Root ProgramData directory for LockScreen.
        /// </summary>
        public static string RootDirectory { get; set; } =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Skylark", "LockScreen");

        /// <summary>
        /// Path to the JSON configuration file.
        /// </summary>
        public static string ConfigPath => Path.Combine(RootDirectory, "config.json");

        /// <summary>
        /// Path to the first-frame cache directory.
        /// </summary>
        public static string CacheDirectory => Path.Combine(RootDirectory, "Cache");

        /// <summary>
        /// Path to the logs directory.
        /// </summary>
        public static string LogsDirectory => Path.Combine(RootDirectory, "Logs");

        #endregion

        #region Configuration Management

        /// <summary>
        /// Ensures all required folders (%ProgramData%\Skylark\LockScreen, Cache, Logs) exist.
        /// </summary>
        public static void EnsureDirectories()
        {
            if (!Directory.Exists(RootDirectory))
            {
                Directory.CreateDirectory(RootDirectory);
            }

            if (!Directory.Exists(CacheDirectory))
            {
                Directory.CreateDirectory(CacheDirectory);
            }

            if (!Directory.Exists(LogsDirectory))
            {
                Directory.CreateDirectory(LogsDirectory);
            }
        }

        /// <summary>
        /// Loads the active lock screen configuration from disk, or returns default if not present.
        /// </summary>
        /// <returns></returns>
        public static SWMLC LoadConfig()
        {
            try
            {
                EnsureDirectories();
                if (File.Exists(ConfigPath))
                {
                    string Json = File.ReadAllText(ConfigPath);
                    return SWMLC.FromJson(Json);
                }
            }
            catch
            {
                // Fallback to default
            }
            return new SWMLC();
        }

        /// <summary>
        /// Saves the configuration to disk and optionally prepares the first-frame cache.
        /// </summary>
        /// <param name="Config"></param>
        /// <param name="PreGenerateCache"></param>
        /// <returns></returns>
        public static bool SaveConfig(SWMLC Config, bool PreGenerateCache = true)
        {
            if (Config == null)
            {
                return false;
            }

            try
            {
                EnsureDirectories();
                string Json = Config.ToJson();
                File.WriteAllText(ConfigPath, Json);

                if (PreGenerateCache && !string.IsNullOrWhiteSpace(Config.MediaPath) && File.Exists(Config.MediaPath))
                {
                    GenerateCache(Config.MediaPath, Config.RenderWidth, Config.FitMode);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Cache Generation

        /// <summary>
        /// Generates an instant first-frame cache for static images or GIFs.
        /// </summary>
        /// <param name="MediaPath"></param>
        /// <param name="RenderWidth"></param>
        /// <param name="FitMode"></param>
        /// <returns></returns>
        public static bool GenerateCache(string MediaPath, int RenderWidth, SELFT FitMode)
        {
            if (string.IsNullOrEmpty(MediaPath) || !File.Exists(MediaPath))
            {
                return false;
            }

            try
            {
                EnsureDirectories();
                int TargetW = RenderWidth / 2 * 2;
                int ScreenW = Screen.PrimaryScreen.Bounds.Width;
                int ScreenH = Screen.PrimaryScreen.Bounds.Height;
                if (ScreenW <= 0)
                {
                    ScreenW = 1920;
                }

                if (ScreenH <= 0)
                {
                    ScreenH = 1080;
                }

                int TargetH = (int)((long)TargetW * ScreenH / ScreenW) / 2 * 2;
                if (TargetH < 180)
                {
                    TargetH = 180;
                }

                string CacheFilePath = SWHLC.GetCacheFilePath(CacheDirectory, MediaPath, TargetW, TargetH, FitMode);

                string Ext = Path.GetExtension(MediaPath).ToLowerInvariant();
                if (Ext is ".gif" or ".png" or ".jpg" or ".jpeg" or ".bmp")
                {
                    using Image Img = Image.FromFile(MediaPath);
                    using Bitmap Bmp = new(Img);
                    return SWHLC.GenerateCacheFromBitmap(Bmp, CacheFilePath, TargetW, TargetH, FitMode);
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Prunes older cache files.
        /// </summary>
        /// <param name="MaxFilesToKeep"></param>
        public static void PruneCache(int MaxFilesToKeep = 5)
        {
            SWHLC.PruneCache(CacheDirectory, MaxFilesToKeep);
        }

        #endregion

        #region Provider Management

        /// <summary>
        /// Checks if the lock screen Credential Provider is registered in Windows.
        /// </summary>
        /// <param name="CLSID"></param>
        /// <returns></returns>
        public static bool IsProviderRegistered(string CLSID = ProviderCLSID)
        {
            try
            {
                using RegistryKey Key = Registry.LocalMachine.OpenSubKey(
                    $@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\Credential Providers\{CLSID}");
                return Key != null;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Registers the lock screen Credential Provider DLL into Windows.
        /// </summary>
        /// <param name="DllPath"></param>
        /// <param name="CLSID"></param>
        /// <param name="DisplayName"></param>
        /// <returns></returns>
        public static bool RegisterProvider(string DllPath, string CLSID = ProviderCLSID, string DisplayName = ProviderDisplayName)
        {
            try
            {
                using (RegistryKey ClsidKey = Registry.LocalMachine.CreateSubKey($@"SOFTWARE\Classes\CLSID\{CLSID}"))
                {
                    ClsidKey.SetValue("", DisplayName);
                    using RegistryKey InprocKey = ClsidKey.CreateSubKey("InprocServer32");
                    InprocKey.SetValue("", DllPath);
                    InprocKey.SetValue("ThreadingModel", "Apartment");
                }

                using (RegistryKey CpKey = Registry.LocalMachine.CreateSubKey(
                    $@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\Credential Providers\{CLSID}"))
                {
                    CpKey.SetValue("", DisplayName);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Unregisters the lock screen Credential Provider from Windows.
        /// </summary>
        /// <param name="CLSID"></param>
        /// <returns></returns>
        public static bool UnregisterProvider(string CLSID = ProviderCLSID)
        {
            try
            {
                Registry.LocalMachine.DeleteSubKeyTree(
                    $@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\Credential Providers\{CLSID}", false);
                Registry.LocalMachine.DeleteSubKeyTree(
                    $@"SOFTWARE\Classes\CLSID\{CLSID}", false);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}