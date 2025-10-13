using System;
using System.Diagnostics;
using System.IO;
using SE = Skylark.Exception;
using SWDDB = Skylark.Wing.Detector.DetectorBase;

namespace Skylark.Wing.Detector
{
    /// <summary>
    /// A simple file lock detector that uses a basic try-catch approach to determine
    /// if a file is locked by attempting to open it with exclusive access.
    /// </summary>
    public class BasicDetector : SWDDB
    {
        /// <summary>
        /// Gets the name of the detector implementation
        /// </summary>
        public override string Name => "Basic";

        /// <summary>
        /// Gets the description of the detection method
        /// </summary>
        public override string Description => "Basic try-catch method that attempts to open the file with exclusive access.";

        /// <summary>
        /// Checks if a file is locked by trying to open it with exclusive access
        /// </summary>
        /// <param name="filePath">The path to the file to check</param>
        /// <returns>True if the file is locked, false otherwise</returns>
        protected override bool CheckIfFileLocked(string filePath)
        {
            try
            {
                // Try to open the file with exclusive access
                using FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);

                // If we got here, the file is not locked
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
            catch (SE ex)
            {
                // Log the exception if necessary
                Debug.WriteLine($"Error checking if file is locked: {ex.Message}");

                // Assume the file is locked if an error occurred
                return true;
            }
        }
    }
}