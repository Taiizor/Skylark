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
        public static AnchorStyles GetAnchorStyle()
        {
            Rectangle coordonates = GetCoordonates();

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
                throw new Win32Exception("Please re-install Windows");
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
                throw new Win32Exception("Windows Taskbar Error in " + nameof(GetCoordonates));
            }

            return new Rectangle(Data.rc.Left, Data.rc.Top, Data.rc.Right - Data.rc.Left, Data.rc.Bottom - Data.rc.Top);
        }
    }
}