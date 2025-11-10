using System.Collections.Generic;
using System.IO;
using SE = Skylark.Exception;
using SWIIFLD = Skylark.Wing.Interface.IFileLockDetector;
using SWMFLI = Skylark.Wing.Model.FileLockInfo;
using SWMPI = Skylark.Wing.Model.ProcessInfo;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// Main class for checking file locks and finding processes that have locked files.
    /// Provides high-level methods that use the recommended detector for the current platform.
    /// </summary>
    public static class FileLocksmith
    {
        /// <summary>
        /// Checks if a file is locked by another process using the recommended detector
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        public static bool IsFileLocked(string filePath)
        {
            SWIIFLD detector = FileLocksmithFactory.CreateRecommendedDetector();
            return detector.IsFileLocked(filePath);
        }

        /// <summary>
        /// Checks if a file is locked by another process using a specific detector
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <param name="detectorName">The name of the detector to use</param>
        /// <returns>True if the file is locked, false otherwise; if the detector is not found, returns false</returns>
        public static bool IsFileLocked(string filePath, string detectorName)
        {
            SWIIFLD? detector = FileLocksmithFactory.CreateDetector(detectorName);
            if (detector == null)
            {
                return false;
            }

            return detector.IsFileLocked(filePath);
        }

        /// <summary>
        /// Gets a list of processes that are locking a file using the recommended detector
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>A collection of ProcessInfo objects representing the processes locking the file</returns>
        public static IEnumerable<SWMPI> GetLockingProcesses(string filePath)
        {
            SWIIFLD detector = FileLocksmithFactory.CreateRecommendedDetector();
            return detector.GetLockingProcesses(filePath);
        }

        /// <summary>
        /// Gets a list of processes that are locking a file using a specific detector
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <param name="detectorName">The name of the detector to use</param>
        /// <returns>A collection of ProcessInfo objects representing the processes locking the file; if the detector is not found, returns an empty collection</returns>
        public static IEnumerable<SWMPI> GetLockingProcesses(string filePath, string detectorName)
        {
            SWIIFLD? detector = FileLocksmithFactory.CreateDetector(detectorName);
            if (detector == null)
            {
                return [];
            }

            return detector.GetLockingProcesses(filePath);
        }

        /// <summary>
        /// Gets detailed information about a file's lock status using the recommended detector
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>A FileLockInfo object containing information about the file's lock status</returns>
        public static SWMFLI GetFileLockInfo(string filePath)
        {
            SWIIFLD detector = FileLocksmithFactory.CreateRecommendedDetector();
            return GetFileLockInfoInternal(filePath, detector);
        }

        /// <summary>
        /// Gets detailed information about a file's lock status using a specific detector
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <param name="detectorName">The name of the detector to use</param>
        /// <returns>A FileLockInfo object containing information about the file's lock status; if the detector is not found, uses the recommended detector</returns>
        public static SWMFLI GetFileLockInfo(string filePath, string detectorName)
        {
            SWIIFLD? detector = FileLocksmithFactory.CreateDetector(detectorName);
            if (detector == null)
            {
                detector = FileLocksmithFactory.CreateRecommendedDetector();
            }

            return GetFileLockInfoInternal(filePath, detector);
        }

        /// <summary>
        /// Gets detailed information about a file's lock status using a specific detector
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <param name="detector">The detector to use</param>
        /// <returns>A FileLockInfo object containing information about the file's lock status</returns>
        private static SWMFLI GetFileLockInfoInternal(string filePath, SWIIFLD detector)
        {
            SWMFLI info = new(filePath)
            {
                DetectionMethod = detector.Name,
                FileExists = File.Exists(filePath)
            };

            if (!info.FileExists)
            {
                return info;
            }

            try
            {
                info.IsLocked = detector.IsFileLocked(filePath);
                if (info.IsLocked)
                {
                    IEnumerable<SWMPI> processes = detector.GetLockingProcesses(filePath);
                    info.LockingProcesses.AddRange(processes);
                }
            }
            catch (SE ex)
            {
                info.IsLocked = true; // Assume locked if there was an error
                info.ErrorMessage = ex.Message;
            }

            return info;
        }

        /// <summary>
        /// Lists all available file lock detectors
        /// </summary>
        /// <returns>A collection of detector names and descriptions</returns>
        public static IEnumerable<(string Name, string Description)> ListAvailableDetectors()
        {
            foreach (SWIIFLD detector in FileLocksmithFactory.GetAllDetectors())
            {
                yield return (detector.Name, detector.Description);
            }
        }
    }
}