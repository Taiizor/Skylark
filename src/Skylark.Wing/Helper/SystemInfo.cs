using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using SE = Skylark.Exception;

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
        /// 
        /// </summary>
        /// <param name="TotalMemoryInKilobytes"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

        /// <summary>
        /// Total installed memory in Megabyte
        /// </summary>
        /// <returns></returns>
        public static long GetTotalInstalledMemory()
        {
            GetPhysicallyInstalledSystemMemory(out long memKb);
            return memKb / 1024;
        }
    }
}