using System.Runtime.InteropServices;
using System.Security;
using SWIIW32API = Skylark.Wing.Interface.IWin32API;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Provider
{
    /// <summary>
    /// Win32 API Provider
    /// </summary>
    /// <remarks>CLR wrapper https://github.com/microsoft/referencesource/blob/master/mscorlib/microsoft/win32/win32native.cs </remarks>
    public class Win32APIProvider : SWIIW32API
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="versionInfo"></param>
        /// <returns></returns>
        [SecurityCritical]
        [DllImport("ntdll.dll", EntryPoint = "RtlGetVersion", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern SWNM.NTSTATUS ntdll_RtlGetVersion(ref SWNM.OSVERSIONINFOEX versionInfo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="smIndex"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        internal static extern int ntdll_GetSystemMetrics(SWNM.SystemMetric smIndex);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="versionInfo"></param>
        /// <returns></returns>
        public SWNM.NTSTATUS RtlGetVersion(ref SWNM.OSVERSIONINFOEX versionInfo)
        {
            return ntdll_RtlGetVersion(ref versionInfo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="smIndex"></param>
        /// <returns></returns>
        public int GetSystemMetrics(SWNM.SystemMetric smIndex)
        {
            return ntdll_GetSystemMetrics(smIndex);
        }
    }
}