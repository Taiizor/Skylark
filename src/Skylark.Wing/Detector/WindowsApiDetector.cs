using Skylark.Wing.Model;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using SWDDB = Skylark.Wing.Detector.DetectorBase;

namespace Skylark.Wing.Detector
{
    /// <summary>
    /// A file lock detector that uses Windows API calls to check if a file is locked
    /// and to find the processes that are locking it. This is the most accurate method
    /// for Windows systems.
    /// </summary>
    public class WindowsApiDetector : SWDDB
    {
        #region Windows API Declarations

        // CreateFile API for checking file locks
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern SafeFileHandle CreateFile(
            string fileName,
            uint desiredAccess,
            uint shareMode,
            IntPtr securityAttributes,
            uint creationDisposition,
            uint flagsAndAttributes,
            IntPtr templateFile);

        // Win32 constants
        private const uint GENERIC_READ = 0x80000000;
        private const uint GENERIC_WRITE = 0x40000000;
        private const uint OPEN_EXISTING = 3;
        private const uint FILE_ATTRIBUTE_NORMAL = 0x80;
        private const uint FILE_SHARE_READ = 0x00000001;
        private const uint FILE_SHARE_WRITE = 0x00000002;
        private const uint FILE_SHARE_DELETE = 0x00000004;

        // RestartManager API for finding processes locking a file
        [DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
        private static extern int RmStartSession(out uint pSessionHandle, int dwSessionFlags, string strSessionKey);

        [DllImport("rstrtmgr.dll")]
        private static extern int RmEndSession(uint pSessionHandle);

        [DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
        private static extern int RmRegisterResources(
            uint pSessionHandle,
            uint nFiles,
            string[] rgsFilenames,
            uint nApplications,
            [In] RM_UNIQUE_PROCESS[]? rgApplications,
            uint nServices,
            string[]? rgsServiceNames);

        [DllImport("rstrtmgr.dll")]
        private static extern int RmGetList(
            uint dwSessionHandle,
            out uint pnProcInfoNeeded,
            ref uint pnProcInfo,
            [In, Out] RM_PROCESS_INFO[]? rgAffectedApps,
            ref uint lpdwRebootReasons);

        [StructLayout(LayoutKind.Sequential)]
        private struct RM_UNIQUE_PROCESS
        {
            public int dwProcessId;
            public System.Runtime.InteropServices.ComTypes.FILETIME ProcessStartTime;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct RM_PROCESS_INFO
        {
            public RM_UNIQUE_PROCESS Process;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string strAppName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string strServiceShortName;
            public RM_APP_TYPE ApplicationType;
            public uint AppStatus;
            public uint TSSessionId;
            [MarshalAs(UnmanagedType.Bool)]
            public bool bRestartable;
        }

        private enum RM_APP_TYPE
        {
            RmUnknownApp = 0,
            RmMainWindow = 1,
            RmOtherWindow = 2,
            RmService = 3,
            RmExplorer = 4,
            RmConsole = 5,
            RmCritical = 1000
        }

        #endregion

        /// <summary>
        /// Gets the name of the detector implementation
        /// </summary>
        public override string Name => "WindowsApi";

        /// <summary>
        /// Gets the description of the detection method
        /// </summary>
        public override string Description => "Uses Windows API calls (CreateFile and RestartManager) to accurately detect file locks and locking processes.";

        /// <summary>
        /// Checks if a file is locked using the Windows API
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        protected override bool CheckIfFileLocked(string filePath)
        {
            // Check if we're running on Windows
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
            {
                throw new PlatformNotSupportedException("The Windows API detector is only supported on Windows.");
            }

            // Try to open the file with no sharing
            SafeFileHandle fileHandle = CreateFile(
                filePath,
                GENERIC_READ | GENERIC_WRITE,
                0, // No sharing
                IntPtr.Zero,
                OPEN_EXISTING,
                FILE_ATTRIBUTE_NORMAL,
                IntPtr.Zero);

            // Check if the file could be opened
            bool isLocked = fileHandle.IsInvalid;

            // Get the error code if the file was locked
            int errorCode = 0;
            if (isLocked)
            {
                errorCode = Marshal.GetLastWin32Error();
            }

            // Close the file handle if it was opened
            if (!fileHandle.IsInvalid)
            {
                fileHandle.Close();
                fileHandle.Dispose();
            }

            // ERROR_SHARING_VIOLATION (32) indicates that the file is being used by another process
            return isLocked && errorCode == 32;
        }

        /// <summary>
        /// Gets a list of processes that are locking a file using the Windows RestartManager API
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>A collection of ProcessInfo objects representing the processes locking the file</returns>
        public override IEnumerable<ProcessInfo> GetLockingProcesses(string filePath)
        {
            List<ProcessInfo> lockingProcesses = new();

            // Check if we're running on Windows
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
            {
                throw new PlatformNotSupportedException("The Windows API detector is only supported on Windows.");
            }

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                return lockingProcesses;
            }

            uint sessionHandle = 0;
            string sessionKey = Guid.NewGuid().ToString();

            try
            {
                // Start a restart manager session
                int result = RmStartSession(out sessionHandle, 0, sessionKey);
                if (result != 0)
                {
                    throw new Win32Exception(result, "Failed to start restart manager session.");
                }

                // Register the file as a resource
                string[] resources = new string[] { Path.GetFullPath(filePath) };
                result = RmRegisterResources(sessionHandle, 1, resources, 0, null, 0, null);
                if (result != 0)
                {
                    throw new Win32Exception(result, "Failed to register resource.");
                }

                // Get the list of processes that are using the file
                uint processInfoCount = 0;
                uint rebootReason = 0;

                // First, get the count of process infos needed
                result = RmGetList(sessionHandle, out uint processInfoNeeded, ref processInfoCount, null, ref rebootReason);
                if (result is not 0 and not 234) // 234 = more data is available
                {
                    throw new Win32Exception(result, "Failed to get process list.");
                }

                if (processInfoNeeded > 0)
                {
                    // Allocate the array and get the process infos
                    RM_PROCESS_INFO[] processInfos = new RM_PROCESS_INFO[processInfoNeeded];
                    processInfoCount = processInfoNeeded;

                    result = RmGetList(sessionHandle, out processInfoNeeded, ref processInfoCount, processInfos, ref rebootReason);
                    if (result != 0)
                    {
                        throw new Win32Exception(result, "Failed to get process list.");
                    }

                    // Create ProcessInfo objects from the process infos
                    for (int i = 0; i < processInfoCount; i++)
                    {
                        try
                        {
                            Process process = Process.GetProcessById(processInfos[i].Process.dwProcessId);
                            ProcessInfo processInfo = new(process.Id, process.ProcessName)
                            {
                                StartTime = process.StartTime,
                                WindowTitle = process.MainWindowTitle,
                                IsRestartable = processInfos[i].bRestartable,
                                ApplicationType = processInfos[i].ApplicationType.ToString()
                            };

                            lockingProcesses.Add(processInfo);
                        }
                        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
                        {
                            // The process might have exited before we could get its details
                            // or we might not have permission to access it
                            ProcessInfo processInfo = new(processInfos[i].Process.dwProcessId, processInfos[i].strAppName)
                            {
                                IsRestartable = processInfos[i].bRestartable,
                                ApplicationType = processInfos[i].ApplicationType.ToString()
                            };

                            lockingProcesses.Add(processInfo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Debug.WriteLine($"Error getting locking processes: {ex.Message}");
            }
            finally
            {
                // End the restart manager session
                if (sessionHandle != 0)
                {
                    RmEndSession(sessionHandle);
                }
            }

            return lockingProcesses;
        }
    }
}