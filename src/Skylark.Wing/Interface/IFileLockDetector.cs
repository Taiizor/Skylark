using Skylark.Wing.Model;
using System.Collections.Generic;

namespace Skylark.Wing.Interface
{
    /// <summary>
    /// Defines methods to check if a file is locked and to find processes locking a file
    /// </summary>
    public interface IFileLockDetector
    {
        /// <summary>
        /// Gets the name of the detector implementation
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the description of the detection method
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Checks if a file is locked by another process
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        bool IsFileLocked(string filePath);

        /// <summary>
        /// Gets a list of processes that are locking a file
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>A collection of ProcessInfo objects representing the processes locking the file</returns>
        IEnumerable<ProcessInfo> GetLockingProcesses(string filePath);
    }
}