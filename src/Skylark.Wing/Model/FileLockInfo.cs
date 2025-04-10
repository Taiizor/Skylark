using System;
using System.Collections.Generic;

namespace Skylark.Wing.Model
{
    /// <summary>
    /// Contains detailed information about the lock status of a file
    /// </summary>
    public class FileLockInfo
    {
        /// <summary>
        /// Gets or sets a value indicating whether the file exists
        /// </summary>
        public bool FileExists { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the file is locked
        /// </summary>
        public bool IsLocked { get; set; }

        /// <summary>
        /// Gets or sets the error message (if any)
        /// </summary>
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the file path
        /// </summary>
        public string FilePath { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the detection method used
        /// </summary>
        public string DetectionMethod { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of processes that are locking the file
        /// </summary>
        public List<ProcessInfo> LockingProcesses { get; set; } = new List<ProcessInfo>();

        /// <summary>
        /// Gets or sets the timestamp when the check was performed
        /// </summary>
        public DateTime CheckTime { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="FileLockInfo"/> class with default values
        /// </summary>
        public FileLockInfo()
        {
            CheckTime = DateTime.Now;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="FileLockInfo"/> class with the specified file path
        /// </summary>
        /// <param name="filePath">The path of the file</param>
        public FileLockInfo(string filePath)
        {
            CheckTime = DateTime.Now;
            FilePath = filePath ?? string.Empty;
        }

        /// <summary>
        /// Returns a string representation of the file lock information
        /// </summary>
        /// <returns>A string describing the lock status</returns>
        public override string ToString()
        {
            if (!FileExists)
            {
                return $"File not found: {FilePath}";
            }

            if (IsLocked)
            {
                return $"File is locked: {FilePath} ({LockingProcesses.Count} locking processes)";
            }

            return $"File is not locked: {FilePath}";
        }
    }
}