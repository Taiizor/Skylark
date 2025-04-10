using System;

namespace Skylark.Wing.Model
{
    /// <summary>
    /// Contains information about a process that is locking a file
    /// </summary>
    public class ProcessInfo
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ProcessInfo"/> class with default values
        /// </summary>
        public ProcessInfo()
        {
            StartTime = DateTime.MinValue;
        }

        /// <summary>
        /// Returns a string representation of the process information
        /// </summary>
        /// <returns>A string containing the process ID and name</returns>
        public override string ToString()
        {
            return $"Process: {ProcessName} (ID: {ProcessId})";
        }

        /// <summary>
        /// Gets or sets the process ID
        /// </summary>
        public int ProcessId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the process can be restarted
        /// </summary>
        public bool IsRestartable { get; set; }

        /// <summary>
        /// Gets or sets the start time of the process
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="ProcessInfo"/> class with the specified process ID and name
        /// </summary>
        /// <param name="processId">The process ID</param>
        /// <param name="processName">The process name</param>
        public ProcessInfo(int processId, string processName)
        {
            ProcessId = processId;
            StartTime = DateTime.MinValue;
            ProcessName = processName ?? string.Empty;
        }

        /// <summary>
        /// Gets or sets the process name
        /// </summary>
        public string ProcessName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the process window title (if available)
        /// </summary>
        public string WindowTitle { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the application type
        /// </summary>
        public string ApplicationType { get; set; } = string.Empty;
    }
}