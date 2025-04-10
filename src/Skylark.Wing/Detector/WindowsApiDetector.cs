using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using SWDDB = Skylark.Wing.Detector.DetectorBase;
using SWMPI = Skylark.Wing.Model.ProcessInfo;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Detector
{
    /// <summary>
    /// A file lock detector that uses Windows API calls to check if a file is locked
    /// and to find the processes that are locking it. This is the most accurate method
    /// for Windows systems.
    /// </summary>
    public class WindowsApiDetector : SWDDB
    {
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
            SafeFileHandle fileHandle = SWNM.CreateFile(
                filePath,
                SWNM.GENERIC_READ | SWNM.GENERIC_WRITE,
                0, // No sharing
                IntPtr.Zero,
                SWNM.OPEN_EXISTING,
                SWNM.FILE_ATTRIBUTE_NORMAL,
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
        public override IEnumerable<SWMPI> GetLockingProcesses(string filePath)
        {
            List<SWMPI> lockingProcesses = new();

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
                int result = SWNM.RmStartSession(out sessionHandle, 0, sessionKey);
                if (result != 0)
                {
                    throw new Win32Exception(result, "Failed to start restart manager session.");
                }

                // Register the file as a resource
                string[] resources = new string[] { Path.GetFullPath(filePath) };
                result = SWNM.RmRegisterResources(sessionHandle, 1, resources, 0, null, 0, null);
                if (result != 0)
                {
                    throw new Win32Exception(result, "Failed to register resource.");
                }

                // Get the list of processes that are using the file
                uint processInfoCount = 0;
                uint rebootReason = 0;

                // First, get the count of process infos needed
                result = SWNM.RmGetList(sessionHandle, out uint processInfoNeeded, ref processInfoCount, null, ref rebootReason);
                if (result is not 0 and not 234) // 234 = more data is available
                {
                    throw new Win32Exception(result, "Failed to get process list.");
                }

                if (processInfoNeeded > 0)
                {
                    // Allocate the array and get the process infos
                    SWNM.RM_PROCESS_INFO[] processInfos = new SWNM.RM_PROCESS_INFO[processInfoNeeded];
                    processInfoCount = processInfoNeeded;

                    result = SWNM.RmGetList(sessionHandle, out processInfoNeeded, ref processInfoCount, processInfos, ref rebootReason);
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
                            SWMPI processInfo = new(process.Id, process.ProcessName)
                            {
                                StartTime = process.StartTime,
                                WindowTitle = process.MainWindowTitle,
                                IsRestartable = processInfos[i].bRestartable,
                                ApplicationType = processInfos[i].ApplicationType.ToString()
                            };

                            lockingProcesses.Add(processInfo);
                        }
                        catch (ArgumentException)
                        {
                            // The process might have exited before we could get its details
                            // or we might not have permission to access it
                            SWMPI processInfo = new(processInfos[i].Process.dwProcessId, processInfos[i].strAppName)
                            {
                                IsRestartable = processInfos[i].bRestartable,
                                ApplicationType = processInfos[i].ApplicationType.ToString()
                            };

                            lockingProcesses.Add(processInfo);
                        }
                        catch (InvalidOperationException)
                        {
                            // The process might have exited before we could get its details
                            // or we might not have permission to access it
                            SWMPI processInfo = new(processInfos[i].Process.dwProcessId, processInfos[i].strAppName)
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
                    SWNM.RmEndSession(sessionHandle);
                }
            }

            return lockingProcesses;
        }
    }
}