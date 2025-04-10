using System.IO;
using SWDDB = Skylark.Wing.Detector.DetectorBase;

namespace Skylark.Wing.Detector
{
    /// <summary>
    /// A file lock detector that uses FileStream with more robust error handling
    /// to check if a file is locked by another process.
    /// </summary>
    public class SafeHandleDetector : SWDDB
    {
        /// <summary>
        /// Gets the name of the detector implementation
        /// </summary>
        public override string Name => "SafeHandle";

        /// <summary>
        /// Gets the description of the detection method
        /// </summary>
        public override string Description => "Uses FileStream with robust error handling to safely check if a file is locked.";

        /// <summary>
        /// Gets or sets the FileAccess mode to use when checking if the file is locked
        /// </summary>
        public FileAccess AccessMode { get; set; } = FileAccess.ReadWrite;

        /// <summary>
        /// Gets or sets the FileShare mode to use when checking if the file is locked
        /// </summary>
        public FileShare ShareMode { get; set; } = FileShare.None;

        /// <summary>
        /// Checks if a file is locked using a safer approach with additional error handling
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        protected override bool CheckIfFileLocked(string filePath)
        {
            FileStream? stream = null;

            try
            {
                // Try to open the file with the specified access and sharing mode
                stream = new FileStream(filePath, FileMode.Open, AccessMode, ShareMode);

                // If we got here, the file is not locked
                return false;
            }
            catch (IOException ex)
            {
                // Check for specific IOException types that indicate locking
                int errorCode = GetWin32ErrorCode(ex);

                // 32 = ERROR_SHARING_VIOLATION (The process cannot access the file because it is being used by another process)
                // 33 = ERROR_LOCK_VIOLATION (The process cannot access the file because another process has locked a portion of the file)
                if (errorCode is 32 or 33)
                {
                    return true; // File is locked
                }

                // Re-throw other IO exceptions
                throw;
            }
            finally
            {
                // Make sure we close the stream if it was opened
                stream?.Close();
                stream?.Dispose();
            }
        }

        /// <summary>
        /// Gets the Win32 error code from an IOException
        /// </summary>
        /// <param name="exception">The exception to get the error code from</param>
        /// <returns>The Win32 error code, or 0 if the error code could not be retrieved</returns>
        private int GetWin32ErrorCode(IOException exception)
        {
            int hResult = exception.HResult;

            // Extract the Win32 error code from the HResult
            // HResult is a 32-bit value with the following format:
            // Bits 31-30: Severity (11 = error)
            // Bit 29: Customer bit (0 = Microsoft, 1 = Customer)
            // Bit 28: Reserved (0)
            // Bits 27-16: Facility code
            // Bits 15-0: Error code (this is what we want)
            return hResult & 0xFFFF;
        }

        /// <summary>
        /// Checks if a file is locked using specific FileAccess and FileShare modes
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <param name="accessMode">The FileAccess mode to use</param>
        /// <param name="shareMode">The FileShare mode to use</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        public bool IsFileLocked(string filePath, FileAccess accessMode, FileShare shareMode)
        {
            // Store the original modes
            FileAccess originalAccessMode = AccessMode;
            FileShare originalShareMode = ShareMode;

            try
            {
                // Set the new modes for this check
                AccessMode = accessMode;
                ShareMode = shareMode;

                // Call the base implementation to check if the file is locked
                return IsFileLocked(filePath);
            }
            finally
            {
                // Restore the original modes
                AccessMode = originalAccessMode;
                ShareMode = originalShareMode;
            }
        }
    }
}