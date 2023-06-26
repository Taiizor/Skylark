using System;
using System.Drawing;
using SSRRS = Skylark.Struct.Rectangles.RectanglesStruct;
using SWMI = Skylark.Wing.Manage.Internal;
using SWNM = Skylark.Wing.Native.Methods;

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
        public static bool IsFullscreen(IntPtr wndHandle, SSRRS screeneRectangles)
        {
            SWNM.GetWindowRect(wndHandle, out SWNM.RECT Rectangle);

            return new Rectangle(Rectangle.Left, Rectangle.Top, Rectangle.Right - Rectangle.Left, Rectangle.Bottom - Rectangle.Top).Contains(screeneRectangles);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static bool IsFullscreen2(IntPtr hWnd)
        {
            int exStyle = SWNM.GetWindowLong(hWnd, -20);

            return ((exStyle & SWMI.WS_EX_TOPMOST) == SWMI.WS_EX_TOPMOST) && ((exStyle & SWMI.WS_EX_TOOLWINDOW) == SWMI.WS_EX_TOOLWINDOW);
        }
    }
}