using System;
using System.Diagnostics;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class ProcessInterop
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        public static IntPtr Handle(Process Process)
        {
            return Process.Handle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        public static IntPtr MainWindowHandle(Process Process)
        {
            return Process.MainWindowHandle;
        }
    }
}