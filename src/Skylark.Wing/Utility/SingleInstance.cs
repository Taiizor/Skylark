using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace Skylark.Wing.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public static class SingleInstance
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static bool IsAppMutexRunning(string Name)
        {
            Mutex Mutex = null;

            try
            {
                return Mutex.TryOpenExisting(Name, out Mutex);
            }
            finally
            {
                Mutex?.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static bool IsAppProcessRunning(string Name)
        {
            return Process.GetProcessesByName(Name).Any();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static bool IsNamedPipeExists(string Name)
        {
            return Directory.GetFiles("\\\\.\\pipe\\").Any(File => File.Equals("\\\\.\\pipe\\" + Name));
        }
    }
}