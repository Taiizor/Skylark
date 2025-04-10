using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using SWDDB = Skylark.Wing.Detector.DetectorBase;

namespace Skylark.Wing.Detector
{
    /// <summary>
    /// A file lock detector that uses FileShare options to determine if a file is locked.
    /// This approach tries to open the file with read sharing, which should work even if
    /// the file is being written to by another process.
    /// </summary>
    public class FileShareDetector : SWDDB
    {
        /// <summary>
        /// Gets the name of the detector implementation
        /// </summary>
        public override string Name => "FileShare";

        /// <summary>
        /// Gets the description of the detection method
        /// </summary>
        public override string Description => "Uses FileShare options to detect file locks, allowing different levels of file sharing.";

        /// <summary>
        /// Gets or sets the FileShare mode to use when checking if the file is locked
        /// </summary>
        public FileShare ShareMode { get; set; } = FileShare.ReadWrite;

        /// <summary>
        /// Checks if a file is locked using the current FileShare mode
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        protected override bool CheckIfFileLocked(string filePath)
        {
            try
            {
                // Try to open the file with the specified sharing mode
                using FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, ShareMode);

                // If we got here, the file is not locked (with respect to the specified sharing mode)
                return false;
            }
            catch (IOException)
            {
                // An IOException is thrown if the file is locked
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                // The file might be read-only or protected
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                Debug.WriteLine($"Error checking if file is locked: {ex.Message}");

                // Assume the file is locked if an error occurred
                return true;
            }
        }

        /// <summary>
        /// Checks if a file is locked using a specific FileShare mode
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <param name="shareMode">The FileShare mode to use</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        public bool IsFileLocked(string filePath, FileShare shareMode)
        {
            // Store the original share mode
            FileShare originalShareMode = ShareMode;

            try
            {
                // Set the new share mode for this check
                ShareMode = shareMode;

                // Call the base implementation to check if the file is locked
                return IsFileLocked(filePath);
            }
            finally
            {
                // Restore the original share mode
                ShareMode = originalShareMode;
            }
        }

        /// <summary>
        /// Checks if a file is locked using different FileShare modes
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>A string containing the results of checking with different FileShare modes</returns>
        public string CheckWithAllShareModes(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                return $"File not found: {filePath}";
            }

            StringBuilder result = new();

            result.AppendLine($"File share mode check for: {filePath}");
            result.AppendLine($"FileShare.None: {(IsFileLocked(filePath, FileShare.None) ? "Locked" : "Not Locked")}");
            result.AppendLine($"FileShare.Read: {(IsFileLocked(filePath, FileShare.Read) ? "Locked" : "Not Locked")}");
            result.AppendLine($"FileShare.Write: {(IsFileLocked(filePath, FileShare.Write) ? "Locked" : "Not Locked")}");
            result.AppendLine($"FileShare.Delete: {(IsFileLocked(filePath, FileShare.Delete) ? "Locked" : "Not Locked")}");
            result.AppendLine($"FileShare.ReadWrite: {(IsFileLocked(filePath, FileShare.ReadWrite) ? "Locked" : "Not Locked")}");

            return result.ToString();
        }
    }
}