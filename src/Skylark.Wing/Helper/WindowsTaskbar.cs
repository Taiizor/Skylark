using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    public static class WindowsTaskbar
    {
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

        public static Rectangle GetPosition()
        {
            SWNM.APPBARDATA data = new();

            data.cbSize = Marshal.SizeOf(data);

            IntPtr retval = SWNM.SHAppBarMessage(SWNM.ABM_GETTASKBARPOS, ref data);

            if (retval == IntPtr.Zero)
            {
                throw new Win32Exception("Please re-install Windows");
            }

            return new Rectangle(data.rc.Left, data.rc.Top, data.rc.Right - data.rc.Left, data.rc.Bottom - data.rc.Top);
        }

        public static Rectangle GetCoordonates()
        {
            SWNM.APPBARDATA data = new();

            data.cbSize = Marshal.SizeOf(data);

            IntPtr retval = SWNM.SHAppBarMessage(SWNM.ABM_GETTASKBARPOS, ref data);

            if (retval == IntPtr.Zero)
            {
                throw new Win32Exception("Windows Taskbar Error in " + nameof(GetCoordonates));
            }

            return new Rectangle(data.rc.Left, data.rc.Top, data.rc.Right - data.rc.Left, data.rc.Bottom - data.rc.Top);
        }
    }
}