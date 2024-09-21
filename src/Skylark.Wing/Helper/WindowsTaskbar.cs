using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class WindowsTaskbar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static AnchorStyles GetAnchorStyle(bool Exception = true)
        {
            Rectangle coordonates = Exception ? GetPosition() : GetCoordonates();

            if (coordonates.Left == 0 && coordonates.Top == 0)
            {
                if (coordonates.Width > SWNM.TaskbarWidthCheckTrigger)
                {
                    return AnchorStyles.Top;
                }
                else
                {
                    return AnchorStyles.Left;
                }
            }
            else
            {
                if (coordonates.Width > SWNM.TaskbarWidthCheckTrigger)
                {
                    return AnchorStyles.Bottom;
                }
                else
                {
                    return AnchorStyles.Right;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Win32Exception"></exception>
        public static Rectangle GetPosition()
        {
            SWNM.APPBARDATA Data = new();

            Data.cbSize = Marshal.SizeOf(Data);

            IntPtr RetVal = SWNM.SHAppBarMessage(SWNM.ABM_GETTASKBARPOS, ref Data);

            if (RetVal == IntPtr.Zero)
            {
                int errorCode = Marshal.GetLastWin32Error();

                throw new Win32Exception(errorCode, $"Windows Taskbar Error in {nameof(GetPosition)}. Error code: {errorCode}");
            }

            return new Rectangle(Data.rc.Left, Data.rc.Top, Data.rc.Right - Data.rc.Left, Data.rc.Bottom - Data.rc.Top);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Win32Exception"></exception>
        public static Rectangle GetCoordonates()
        {
            SWNM.APPBARDATA Data = new();

            Data.cbSize = Marshal.SizeOf(Data);

            IntPtr RetVal = SWNM.SHAppBarMessage(SWNM.ABM_GETTASKBARPOS, ref Data);

            if (RetVal == IntPtr.Zero)
            {
                Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
                Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                int taskbarHeight = screenBounds.Height - workingArea.Height;

                if (taskbarHeight > 0)
                {
                    return new Rectangle(0, screenBounds.Height - taskbarHeight, screenBounds.Width, taskbarHeight);
                }
                else
                {
                    int taskbarWidth = screenBounds.Width - workingArea.Width;

                    return new Rectangle(screenBounds.Width - taskbarWidth, 0, taskbarWidth, screenBounds.Height);
                }
            }

            return new Rectangle(Data.rc.Left, Data.rc.Top, Data.rc.Right - Data.rc.Left, Data.rc.Bottom - Data.rc.Top);
        }
    }
}