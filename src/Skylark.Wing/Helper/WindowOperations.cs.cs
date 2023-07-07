using System;
using System.Runtime.InteropServices;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class WindowOperations
    {
        public static void SetParentSafe(IntPtr child, IntPtr parent)
        {
            IntPtr ret = SWNM.SetParent(child, parent);

            if (ret.Equals(IntPtr.Zero))
            {
                //Debug.WriteLine("Failed to set window parent");
            }
        }

        /// <summary>
        /// Makes window toolwindow and force remove from taskbar.
        /// </summary>
        /// <param name="handle">window handle</param>
        public static void RemoveWindowFromTaskbar(IntPtr handle)
        {
            IntPtr styleCurrentWindowExtended = SWNM.GetWindowLongPtr(handle, (int)SWNM.GWL.GWL_EXSTYLE);

            long styleNewWindowExtended = styleCurrentWindowExtended.ToInt64() |
                   (long)SWNM.WindowStyles.WS_EX_NOACTIVATE |
                   (long)SWNM.WindowStyles.WS_EX_TOOLWINDOW;

            //update window styles
            //https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setwindowlongptra
            //Certain window data is cached, so changes you make using SetWindowLongPtr will not take effect until you call the SetWindowPos function?
            SWNM.ShowWindow(handle, (int)SWNM.SHOWWINDOW.SW_HIDE);

            if (SWNM.SetWindowLongPtr(new HandleRef(null, handle), (int)SWNM.GWL.GWL_EXSTYLE, (IntPtr)styleNewWindowExtended) == IntPtr.Zero)
            {
                //LogUtil.LogWin32Error("Failed to modify window style");
            }

            SWNM.ShowWindow(handle, (int)SWNM.SHOWWINDOW.SW_SHOW);
        }

        /// <summary>
        /// Removes window border and some menuitems. Won't remove everything in apps with custom UI system.<para>
        /// Ref: https://github.com/Codeusa/Borderless-Gaming
        /// </para>
        /// </summary>
        /// <param name="handle">Window handle</param>
        public static void BorderlessWinStyle(IntPtr handle)
        {
            // Get window styles
            IntPtr styleCurrentWindowStandard = SWNM.GetWindowLongPtr(handle, (int)SWNM.GWL.GWL_STYLE);
            IntPtr styleCurrentWindowExtended = SWNM.GetWindowLongPtr(handle, (int)SWNM.GWL.GWL_EXSTYLE);

            // Compute new styles (XOR of the inverse of all the bits to filter)
            long styleNewWindowStandard = styleCurrentWindowStandard.ToInt64()
                & ~(
                    (long)SWNM.WindowStyles.WS_CAPTION // composite of Border and DialogFrame          
                    | (long)SWNM.WindowStyles.WS_THICKFRAME
                    | (long)SWNM.WindowStyles.WS_SYSMENU
                    | (long)SWNM.WindowStyles.WS_MAXIMIZEBOX // same as TabStop
                    | (long)SWNM.WindowStyles.WS_MINIMIZEBOX // same as Group
                );


            long styleNewWindowExtended = styleCurrentWindowExtended.ToInt64()
                & ~(
                      (long)SWNM.WindowStyles.WS_EX_DLGMODALFRAME
                    | (long)SWNM.WindowStyles.WS_EX_COMPOSITED
                    | (long)SWNM.WindowStyles.WS_EX_WINDOWEDGE
                    | (long)SWNM.WindowStyles.WS_EX_CLIENTEDGE
                    | (long)SWNM.WindowStyles.WS_EX_LAYERED
                    | (long)SWNM.WindowStyles.WS_EX_STATICEDGE
                    | (long)SWNM.WindowStyles.WS_EX_TOOLWINDOW
                    | (long)SWNM.WindowStyles.WS_EX_APPWINDOW
                );

            // update window styles
            if (SWNM.SetWindowLongPtr(new HandleRef(null, handle), (int)SWNM.GWL.GWL_STYLE, (IntPtr)styleNewWindowStandard) == IntPtr.Zero)
            {
                //Debug.WriteLine("Failed to modify window style(1)");
            }

            if (SWNM.SetWindowLongPtr(new HandleRef(null, handle), (int)SWNM.GWL.GWL_EXSTYLE, (IntPtr)styleNewWindowExtended) == IntPtr.Zero)
            {
                //Debug.WriteLine("Failed to modify window style(2)");
            }

            // remove the menu and menuitems and force a redraw
            IntPtr menuHandle = SWNM.GetMenu(handle);
            if (menuHandle != IntPtr.Zero)
            {
                int menuItemCount = SWNM.GetMenuItemCount(menuHandle);

                for (int i = 0; i < menuItemCount; i++)
                {
                    SWNM.RemoveMenu(menuHandle, 0, SWNM.MF_BYPOSITION | SWNM.MF_REMOVE);
                }

                SWNM.DrawMenuBar(handle);
            }
        }

        private const int LWA_ALPHA = 0x2;
        private const int LWA_COLORKEY = 0x1;

        /// <summary>
        /// Set window alpha.
        /// </summary>
        /// <param name="Handle"></param>
        public static void SetWindowTransparency(IntPtr Handle)
        {
            IntPtr styleCurrentWindowExtended = SWNM.GetWindowLongPtr(Handle, -20);
            long styleNewWindowExtended = styleCurrentWindowExtended.ToInt64() ^ SWNM.WindowStyles.WS_EX_LAYERED;

            SWNM.SetWindowLongPtr(new HandleRef(null, Handle), (int)SWNM.GWL.GWL_EXSTYLE, (IntPtr)styleNewWindowExtended);
            SWNM.SetLayeredWindowAttributes(Handle, 0, 128, LWA_ALPHA);
        }
    }
}