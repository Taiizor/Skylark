using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace Skylark.Wing.Utility
{
    public static class SingleInstance
    {
        public static bool IsAppMutexRunning(string mutexName)
        {
            Mutex mutex = null;

            try
            {
                return Mutex.TryOpenExisting(mutexName, out mutex);
            }
            finally
            {
                mutex?.Dispose();
            }
        }

        public static bool IsAppProcessRunning(string processName)
        {
            return Process.GetProcessesByName(processName).Count() != 0;
        }

        public static bool IsNamedPipeExists(string pipeName)
        {
            return Directory.GetFiles("\\\\.\\pipe\\").Any(f => f.Equals("\\\\.\\pipe\\" + pipeName));
        }
    }
}
