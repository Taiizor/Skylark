using System;
using System.Windows;
using System.Windows.Interop;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class WindowInterop
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <returns></returns>
        public static IntPtr Owner(Window Window)
        {
            return InteropHelper(Window).Owner;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <returns></returns>
        public static IntPtr Handle(Window Window)
        {
            return InteropHelper(Window).Handle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <returns></returns>
        public static IntPtr EnsureHandle(Window Window)
        {
            return InteropHelper(Window).EnsureHandle();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <returns></returns>
        public static WindowInteropHelper InteropHelper(Window Window)
        {
            return new WindowInteropHelper(Window);
        }
    }
}