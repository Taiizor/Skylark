using System;
using SWIIE = Skylark.Wing.Interface.IEnvironment;

namespace Skylark.Wing.Provider
{
    /// <summary>
    /// 
    /// </summary>
    public class EnvironmentProvider : SWIIE
    {
        /// <summary>
        /// 
        /// </summary>
        public EnvironmentProvider()
        {
            // NOPE
        }

        /// <summary>
        /// Determines whether the current operating system is a 64-bit operating system.
        /// </summary>
        /// <returns>true if the operating system is 64-bit; otherwise, false.</returns>
        public bool Is64BitOperatingSystem()
        {
            return Environment.Is64BitOperatingSystem;
        }
    }
}