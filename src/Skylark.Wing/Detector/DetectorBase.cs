using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using SE = Skylark.Exception;
using SWIIFLD = Skylark.Wing.Interface.IFileLockDetector;
using SWMPI = Skylark.Wing.Model.ProcessInfo;

namespace Skylark.Wing.Detector
{
    /// <summary>
    /// Base class for file lock detectors providing common functionality
    /// </summary>
    public abstract class DetectorBase : SWIIFLD
    {
        /// <summary>
        /// Gets the name of the detector implementation
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the description of the detection method
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Checks if a file is locked by another process
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        public virtual bool IsFileLocked(string filePath)
        {
            // Validate the file path
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
            }

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                return false; // File doesn't exist, so it can't be locked
            }

            try
            {
                // Implement the file lock check in derived classes
                return CheckIfFileLocked(filePath);
            }
            catch (SE ex)
            {
                // Log the exception if necessary
                Debug.WriteLine($"Error checking if file is locked: {ex.Message}");

                // Assume the file is locked if an error occurred
                return true;
            }
        }

        /// <summary>
        /// Implement this method in derived classes to perform the actual file lock check
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        protected abstract bool CheckIfFileLocked(string filePath);

        /// <summary>
        /// Gets a list of processes that are locking a file
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>A collection of ProcessInfo objects representing the processes locking the file</returns>
        public virtual IEnumerable<SWMPI> GetLockingProcesses(string filePath)
        {
            // By default, detector implementations might not support process detection
            // and will return an empty list. Override this method in derived classes
            // to implement specific process detection logic.
            return new List<SWMPI>();
        }
    }
}