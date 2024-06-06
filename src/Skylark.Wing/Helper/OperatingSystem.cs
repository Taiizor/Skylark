using Microsoft.Win32;
using System;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using SEOST = Skylark.Enum.OperatingSystemType;
using SWNM = Skylark.Wing.Native.Methods;

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
        public static int GetRevisionNumber()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            return Convert.ToInt32(registryKey.GetValue("UBR").ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Version GetRTLVersion()
        {
            SWNM.OSVERSIONINFOEX versionInfo = new()
            {
                OSVersionInfoSize = Marshal.SizeOf<SWNM.OSVERSIONINFOEX>()
            };

            SWNM.RtlGetVersion(ref versionInfo);

            return new Version(versionInfo.MajorVersion, versionInfo.MinorVersion, versionInfo.BuildNumber);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Version GetRTLRVersion()
        {
            Version versionInfo = GetRTLVersion();

            return new Version(versionInfo.Major, versionInfo.Minor, versionInfo.Build, GetRevisionNumber());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Version GetRegistryVersion()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            return Version.Parse(registryKey.GetValue("LCUVer").ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Version GetManagementVersion()
        {
            using ManagementObjectSearcher myOperativeSystemObject = new("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject obj in myOperativeSystemObject.Get().Cast<ManagementObject>())
            {
                return Version.Parse(obj["Version"].ToString());
            }

            return new Version(0, 0, 0, 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Version GetEnvironmentVersion()
        {
            return Environment.OSVersion.Version;
        }

        /// <summary>
        /// https://en.wikipedia.org/wiki/List_of_Microsoft_Windows_versions
        /// </summary>
        /// <returns></returns>
        public static SEOST GetSystem(Version WindowsVersion)
        {
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
            else if (IsInRange(WindowsVersion, "6.1.7600.0", "6.2.0.0"))
            {
                return SEOST.Windows7;
            }
            else if (IsInRange(WindowsVersion, "6.0.6000.0", "6.1.0.0"))
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
        public static string GetProcessorArchitecture()
        {
            return $"{Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Architecture GetProcessArchitecture()
        {
            return RuntimeInformation.ProcessArchitecture;
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
            return IsInRange(WindowsVersion, new Version(MinVersion), new Version(MaxVersion));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="WindowsVersion"></param>
        /// <param name="MinVersion"></param>
        /// <param name="MaxVersion"></param>
        /// <returns></returns>
        private static bool IsInRange(Version WindowsVersion, Version MinVersion, Version MaxVersion)
        {
            return WindowsVersion >= MinVersion && WindowsVersion < MaxVersion;
        }
    }
}