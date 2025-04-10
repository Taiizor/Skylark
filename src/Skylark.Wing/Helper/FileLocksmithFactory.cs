using System;
using System.Collections.Generic;
using System.Linq;
using SWDBD = Skylark.Wing.Detector.BasicDetector;
using SWDFSD = Skylark.Wing.Detector.FileShareDetector;
using SWDSHD = Skylark.Wing.Detector.SafeHandleDetector;
using SWDWAD = Skylark.Wing.Detector.WindowsApiDetector;
using SWIIFLD = Skylark.Wing.Interface.IFileLockDetector;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// Factory class to create instances of file lock detectors
    /// </summary>
    public static class FileLocksmithFactory
    {
        /// <summary>
        /// Gets all available file lock detectors
        /// </summary>
        /// <returns>A collection of all available file lock detectors</returns>
        public static IEnumerable<SWIIFLD> GetAllDetectors()
        {
            return new SWIIFLD[]
            {
                new SWDBD(),
                new SWDFSD(),
                new SWDSHD(),
                new SWDWAD()
            };
        }

        /// <summary>
        /// Creates a new instance of a file lock detector by its name
        /// </summary>
        /// <param name="detectorName">The name of the detector to create</param>
        /// <returns>An instance of the specified detector, or null if no matching detector was found</returns>
        public static SWIIFLD? CreateDetector(string detectorName)
        {
            if (string.IsNullOrWhiteSpace(detectorName))
            {
                return null;
            }

            return GetAllDetectors().FirstOrDefault(d =>
                string.Equals(d.Name, detectorName, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Creates a new instance of the recommended file lock detector for the current operating system
        /// </summary>
        /// <returns>The recommended file lock detector</returns>
        public static SWIIFLD CreateRecommendedDetector()
        {
            // For Windows, the WindowsApiDetector provides the best results
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                return new SWDWAD();
            }

            // For other operating systems, use the BasicDetector
            return new SWDBD();
        }
    }
}