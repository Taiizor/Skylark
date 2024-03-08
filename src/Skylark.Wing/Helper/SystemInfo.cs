using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using SE = Skylark.Exception;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// Retrieve system information:- operating system version, cpu, gpu etc..
    /// </summary>
    public static class SystemInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetGpuInfo()
        {
            try
            {
                using ManagementObjectSearcher myVideoObject = new("SELECT * FROM Win32_VideoController");

                StringBuilder Builder = new();

                foreach (ManagementObject obj in myVideoObject.Get().Cast<ManagementObject>())
                {
                    Builder.AppendLine("GPU: " + obj["Name"]);
                }

                return Builder.ToString().TrimEnd();
            }
            catch (SE e)
            {
                return "GPU: " + e.Message;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<string> GetGpu()
        {
            List<string> result = new();

            try
            {
                using ManagementObjectSearcher myVideoObject = new("SELECT * FROM Win32_VideoController");

                foreach (ManagementObject obj in myVideoObject.Get().Cast<ManagementObject>())
                {
                    result.Add(obj["Name"].ToString());
                }
            }
            catch { }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetCpuInfo()
        {
            try
            {
                using ManagementObjectSearcher myProcessorObject = new("SELECT * FROM Win32_Processor");

                StringBuilder Builder = new();

                foreach (ManagementObject obj in myProcessorObject.Get().Cast<ManagementObject>())
                {
                    Builder.AppendLine("CPU: " + obj["Name"]);
                }

                return Builder.ToString().TrimEnd();
            }
            catch (SE e)
            {
                return "CPU: " + e.Message;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<string> GetCpu()
        {
            List<string> result = new();

            try
            {
                using ManagementObjectSearcher myProcessorObject = new("SELECT * FROM Win32_Processor");

                foreach (ManagementObject obj in myProcessorObject.Get().Cast<ManagementObject>())
                {
                    result.Add(obj["Name"].ToString());
                }
            }
            catch { }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetOSInfo()
        {
            try
            {
                using ManagementObjectSearcher myOperativeSystemObject = new("SELECT * FROM Win32_OperatingSystem");

                StringBuilder Builder = new();

                foreach (ManagementObject obj in myOperativeSystemObject.Get().Cast<ManagementObject>())
                {
                    Builder.AppendLine("OS: " + obj["Caption"] + " " + obj["Version"]);
                }

                return Builder.ToString().TrimEnd();
            }
            catch (SE e)
            {
                return "OS: " + e.Message;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool CheckWindowsNorKN()
        {
            bool result = false;

            try
            {
                int sku = 0;
                using ManagementObjectSearcher myOperativeSystemObject = new("SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementObject obj in myOperativeSystemObject.Get().Cast<ManagementObject>())
                {
                    sku = int.Parse(obj["OperatingSystemSKU"].ToString());
                    break;
                }

                //ref: https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getproductinfo
                result = sku is 5 or 16 or 26 or 27 or 28 or 47 or 49 or 84 or 122 or 162;
            }
            catch { }

            return result;
        }

        /// <summary>
        /// Total installed memory in Megabyte
        /// </summary>
        /// <returns></returns>
        public static long GetTotalInstalledMemory()
        {
            SWNM.GetPhysicallyInstalledSystemMemory(out long memKb);

            return memKb / 1024;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SWNM.SYSTEM_INFO GetSystemInfo()
        {
            SWNM.SYSTEM_INFO SystemInfo = new();

            SWNM.GetNativeSystemInfo(ref SystemInfo);

            return SystemInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetSystemInfoArchitecture()
        {
            SWNM.SYSTEM_INFO SystemInfo = GetSystemInfo();

            return SystemInfo.processorArchitecture switch
            {
                0 => "x86",
                5 => "ARM",
                6 => "IA64",
                7 => "Alpha",
                9 => "x64",
                10 => "PPC",
                12 => "ARM64",
                13 => "SHX",
                14 => "IA32_ON_WIN64",
                15 => "AMD64_ON_WIN64",
                16 => "WOW64",
                17 => "IA64_ON_WIN64",
                18 => "WOW64_IA64",
                19 => "WOW64_ARM64",
                _ => "Unknown",
            };
        }
    }
}