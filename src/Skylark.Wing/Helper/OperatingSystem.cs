using System;
using SEOST = Skylark.Enum.OperatingSystemType;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class OperatingSystem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool Is32Bit()
        {
            return !Is64Bit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool Is64Bit()
        {
            return Environment.Is64BitOperatingSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SEOST GetSystem()
        {
            Version WindowsVersion = GetVersion();

            if (IsInRange(WindowsVersion, "10.0.22000.0", "10.0.30000.0"))
            {
                return SEOST.Windows11;
            }
            else if (IsInRange(WindowsVersion, "10.0.20348.0", "10.0.21000.0"))
            {
                return SEOST.WindowsServer2022;
            }
            else if (IsInRange(WindowsVersion, "10.0.17763.0", "10.0.18000.0"))
            {
                return SEOST.WindowsServer2019;
            }
            else if (IsInRange(WindowsVersion, "10.0.14393.0", "10.0.15000.0"))
            {
                return SEOST.WindowsServer2016;
            }
            else if (IsInRange(WindowsVersion, "10.0.10240.0", "10.0.19045.0"))
            {
                return SEOST.Windows10;
            }
            else if (IsInRange(WindowsVersion, "6.3.9600.0", "6.4.0.0"))
            {
                return SEOST.Windows8_1;
            }
            else if (IsInRange(WindowsVersion, "6.2.9200.0", "6.3.0.0"))
            {
                return SEOST.Windows8;
            }
            else if (IsInRange(WindowsVersion, "6.1.7601.0", "6.2.0.0"))
            {
                return SEOST.Windows7;
            }
            else if (IsInRange(WindowsVersion, "6.0.6002.0", "6.1.0.0"))
            {
                return SEOST.WindowsVista;
            }
            else
            {
                return SEOST.Unknown;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Version GetVersion()
        {
            return Environment.OSVersion.Version;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="WindowsVersion"></param>
        /// <param name="MinVersion"></param>
        /// <param name="MaxVersion"></param>
        /// <returns></returns>
        private static bool IsInRange(Version WindowsVersion, string MinVersion, string MaxVersion)
        {
            Version Min = new(MinVersion);
            Version Max = new(MaxVersion);

            return WindowsVersion >= Min && WindowsVersion < Max;
        }
    }
}