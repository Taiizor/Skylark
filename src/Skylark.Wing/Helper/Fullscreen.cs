using System;
using System.Drawing;
using MI = Skylark.Wing.Manage.Internal;
using NM = Skylark.Wing.Native.Methods;
using SRRS = Skylark.Struct.Rectangles.RectanglesStruct;

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
        /// <param name="wndHandle"></param>
        /// <param name="screeneRectangles"></param>
        /// <returns></returns>
        public static bool IsFullscreen(IntPtr wndHandle, SRRS screeneRectangles)
        {
            NM.GetWindowRect(wndHandle, out NM.RECT Rectangle);

            return new Rectangle(Rectangle.Left, Rectangle.Top, Rectangle.Right - Rectangle.Left, Rectangle.Bottom - Rectangle.Top).Contains(screeneRectangles);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static bool IsFullscreen2(IntPtr hWnd)
        {
            int exStyle = NM.GetWindowLong(hWnd, -20);

            return ((exStyle & MI.WS_EX_TOPMOST) == MI.WS_EX_TOPMOST) && ((exStyle & MI.WS_EX_TOOLWINDOW) == MI.WS_EX_TOOLWINDOW);
        }
    }
}