using System;
using System.Runtime.InteropServices;
using System.Security;
using SEOST = Skylark.Enum.OperatingSystemType;
using SWHVI = Skylark.Wing.Helper.VersionInfo;
using SWIIE = Skylark.Wing.Interface.IEnvironment;
using SWIIW32API = Skylark.Wing.Interface.IWin32API;
using SWNM = Skylark.Wing.Native.Methods;
using SWPEP = Skylark.Wing.Provider.EnvironmentProvider;
using SWPMV10P = Skylark.Wing.Provider.MajorVersion10Provider;
using SWPW32APIP = Skylark.Wing.Provider.Win32APIProvider;

namespace Skylark.Wing.Extension
{
    /// <summary>
    /// Detects Windows version starting with Windows 2000 and also works on Windows 11/ Windows 10/Server 2022/Server 2019/Server 2016 right away.
    /// </summary>
    /// <remarks>
    /// References:
    /// OSVERSIONINFOEXA structure https://docs.microsoft.com/de-de/windows/win32/api/winnt/ns-winnt-osversioninfoexa
    /// OSVERSIONINFOEX uses incorrect charset with RtlGetVersion() https://github.com/windows-toolkit/WindowsCommunityToolkit/issues/2095
    /// taken from https://stackoverflow.com/a/49641055
    /// </remarks>
    [SecurityCritical]
    public static class OperatingSystem
    {
        /// <summary>
        /// Default provider for the Win32 API.
        /// </summary>
        private static readonly SWIIW32API _win32ApiProviderDefault;

        /// <summary>
        /// Default provider for the Windows environment.
        /// </summary>
        private static readonly SWIIE _environmentProviderDefault;

        /// <summary>
        /// Provider for working with the Win32 API.
        /// </summary>
        private static SWIIW32API _win32ApiProvider;

        /// <summary>
        /// Provider for getting information about the Windows environment.
        /// </summary>
        private static SWIIE _environmentProvider;

        /// <summary>
        /// 
        /// </summary>
        public static int MajorVersion => DetectWindowsVersion(_win32ApiProvider).MajorVersion;

        /// <summary>
        /// 
        /// </summary>
        public static int MinorVersion => DetectWindowsVersion(_win32ApiProvider).MinorVersion;

        /// <summary>
        /// 
        /// </summary>
        public static int BuildNumber => DetectWindowsVersion(_win32ApiProvider).BuildNumber;

        /// <summary>
        /// 
        /// </summary>
        public static bool Is64BitOperatingSystem => GetIf64BitOperatingSystem();

        /// <summary>
        /// 
        /// </summary>
        public static bool IsWorkstation => GetIfWorkStation();

        /// <summary>
        /// 
        /// </summary>
        public static bool IsServer => GetIfServer();

        /// <summary>
        /// 
        /// </summary>
        [SecurityCritical]
        static OperatingSystem()
        {
            _win32ApiProviderDefault = new SWPW32APIP();
            _environmentProviderDefault = new SWPEP();

            _win32ApiProvider = _win32ApiProviderDefault;
            _environmentProvider = _environmentProviderDefault;
        }

        /// <summary>
        /// Gets the version information and build number.
        /// </summary>
        /// <remarks></remarks>
        /// <returns>Returns <see cref="SWHVI"/>, e.g 10.0.19043</returns>        
        public static SWHVI GetOSVersion()
        {
            return new SWHVI(MajorVersion, MinorVersion, BuildNumber);
        }

        /// <summary>
        /// Returns the Windows version.
        /// </summary>
        /// <returns></returns>
        /// <remarks>detection based on https://docs.microsoft.com/de-de/windows-hardware/drivers/ddi/wdm/ns-wdm-_osversioninfoexw#remarks </remarks>
        public static SEOST GetOperatingSystem()
        {
            SWNM.SuiteMask suiteMask = DetectWindowsVersion(_win32ApiProvider).SuiteMask;

            if (MajorVersion == 10 && MinorVersion == 0 && BuildNumber >= 22000 && IsWorkstation)
            {
                return SEOST.Windows11;
            }
            else if (MajorVersion == 10 && MinorVersion == 0 && BuildNumber >= 20348 && IsServer)
            {
                return SEOST.WindowsServer2022;
            }
            else if (MajorVersion == 10 && MinorVersion == 0 && IsWorkstation)
            {
                return SEOST.Windows10;
            }
            else if (MajorVersion == 10 && MinorVersion == 0 && BuildNumber >= 17763 && IsServer)
            {
                return SEOST.WindowsServer2019;
            }
            else if (MajorVersion == 10 && MinorVersion == 0 && IsServer)
            {
                return SEOST.WindowsServer2016;
            }
            else if (MajorVersion == 6 && MinorVersion == 3 && IsServer)
            {
                return SEOST.WindowsServer2012R2;
            }
            else if (MajorVersion == 6 && MinorVersion == 3 && IsWorkstation)
            {
                return SEOST.Windows8_1;
            }
            else if (MajorVersion == 6 && MinorVersion == 2 && IsWorkstation)
            {
                return SEOST.Windows8;
            }
            else if (MajorVersion == 6 && MinorVersion == 2 && IsServer)
            {
                return SEOST.WindowsServer2012;
            }
            else if (MajorVersion == 6 && MinorVersion == 1 && IsWorkstation)
            {
                return SEOST.Windows7;
            }
            else if (MajorVersion == 6 && MinorVersion == 1 && IsServer)
            {
                return SEOST.WindowsServer2008R2;
            }
            else if (MajorVersion == 6 && MinorVersion == 0 && IsServer)
            {
                return SEOST.WindowsServer2008;
            }
            else if (MajorVersion == 6 && MinorVersion == 0 && IsWorkstation)
            {
                return SEOST.WindowsVista;
            }
            else if (MajorVersion == 5 && MinorVersion == 2 && IsServer && ReadSystemMetrics(SWNM.SystemMetric.SM_SERVERR2) != 0)
            {
                return SEOST.WindowsServer2003R2;
            }
            else if (MajorVersion == 5 && MinorVersion == 2 && IsServer && ReadSystemMetrics(SWNM.SystemMetric.SM_SERVERR2) == 0 && (suiteMask & SWNM.SuiteMask.VER_SUITE_WH_SERVER) != SWNM.SuiteMask.VER_SUITE_WH_SERVER)
            {
                return SEOST.WindowsServer2003;
            }
            else if (MajorVersion == 5 && MinorVersion == 2 && (suiteMask & SWNM.SuiteMask.VER_SUITE_WH_SERVER) == SWNM.SuiteMask.VER_SUITE_WH_SERVER)
            {
                return SEOST.WindowsHomeServer;
            }
            else if (MajorVersion == 5 && MinorVersion == 2 && IsWorkstation && Is64BitOperatingSystem)
            {
                return SEOST.WindowsXPProx64;
            }
            else if (MajorVersion == 5 && MinorVersion == 1)
            {
                return SEOST.WindowsXP;
            }
            else if (MajorVersion == 5 && MinorVersion == 0)
            {
                return SEOST.Windows2000;
            }

            return SEOST.Unknown;
        }

        /// <summary>
        /// Use custom Win32 API provider.
        /// </summary>
        /// <param name="win32ApiProvider"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void SetWin32ApiProvider(SWIIW32API win32ApiProvider)
        {
            _ = win32ApiProvider ?? throw new ArgumentNullException();

            _win32ApiProvider = win32ApiProvider;
        }

        /// <summary>
        /// Use custom Environment provider
        /// </summary>
        /// <param name="environmentProvider"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void SetEnvironmentProvider(SWIIE environmentProvider)
        {
            _ = environmentProvider ?? throw new ArgumentNullException();

            _environmentProvider = environmentProvider;
        }

        /// <summary>
        /// Sets the Win32API Provider to default.
        /// </summary>
        public static void SetWin32ApiProviderDefault()
        {
            _win32ApiProvider = _win32ApiProviderDefault;
        }

        /// <summary>
        /// Sets the Environment provider to default.
        /// </summary>
        public static void SetEnvironmentProviderDefault()
        {
            _environmentProvider = _environmentProviderDefault;
        }

        /// <summary>
        /// Returns additional properties for Windows systems having major version 10 or higher
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Cannot be called on systems other than Windows 10</exception>
        public static SWPMV10P MajorVersion10Provider()
        {
            if (MajorVersion < 10)
            {
                throw new InvalidOperationException("Cannot be called on systems earlier than version 10.");
            }

            SWPMV10P MajorVersion10Provider = new();

            return MajorVersion10Provider;
        }

        private static SWNM.OSVERSIONINFOEX DetectWindowsVersion(SWIIW32API win32ApiProvider)
        {
            SWNM.OSVERSIONINFOEX osVersionInfo = new() { OSVersionInfoSize = Marshal.SizeOf(typeof(SWNM.OSVERSIONINFOEX)) };

            if (win32ApiProvider.RtlGetVersion(ref osVersionInfo) != SWNM.NTSTATUS.STATUS_SUCCESS)
            {
                throw new InvalidOperationException($"Failed to call internal {nameof(win32ApiProvider.RtlGetVersion)}.");
            }

            return osVersionInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static bool GetIfServer()
        {
            SWNM.ProductType productType = DetectWindowsVersion(_win32ApiProvider).ProductType;

            return productType is SWNM.ProductType.DomainController or SWNM.ProductType.Server;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static bool GetIfWorkStation()
        {
            SWNM.ProductType productType = DetectWindowsVersion(_win32ApiProvider).ProductType;

            return productType == SWNM.ProductType.Workstation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static bool GetIf64BitOperatingSystem()
        {
            return _environmentProvider.Is64BitOperatingSystem();
        }

        /// <summary>
        /// The system metric or configuration setting to be retrieved. 
        /// Note that all SM_CX* values are widths and all SM_CY* values are heights. 
        /// Also note that all settings designed to return Boolean data represent TRUE as any nonzero value, and FALSE as a zero value.
        /// </summary>
        /// <param name="smIndex"></param>
        /// <returns></returns>
        /// <remarks>https://docs.microsoft.com/de-de/windows/win32/api/winuser/nf-winuser-getsystemmetrics</remarks>
        private static int ReadSystemMetrics(SWNM.SystemMetric smIndex)
        {
            return _win32ApiProvider.GetSystemMetrics(smIndex);
        }
    }
}