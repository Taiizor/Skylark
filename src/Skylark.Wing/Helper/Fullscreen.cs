using System;
using MI = Skylark.Wing.Manage.Internal;
using NM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Fullscreen
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static bool IsFullScreen(IntPtr hWnd)
        {
            int exStyle = NM.GetWindowLong(hWnd, -20);

            return ((exStyle & MI.WS_EX_TOPMOST) == MI.WS_EX_TOPMOST) && ((exStyle & MI.WS_EX_TOOLWINDOW) == MI.WS_EX_TOOLWINDOW);
        }
    }
}