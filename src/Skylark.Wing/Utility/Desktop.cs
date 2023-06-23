using System;
using NM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Utility
{
    public static class Desktop
    {
        public static bool DesktopIconVisibilityDefault { get; }

        static Desktop()
        {
            DesktopIconVisibilityDefault = GetDesktopIconVisibility();
        }

        public static bool GetDesktopIconVisibility()
        {
            NM.SHELLSTATE state = new();
            NM.SHGetSetSettings(ref state, NM.SSF.SSF_HIDEICONS, false); //get state
            return !state.fHideIcons;
        }

        //ref: https://stackoverflow.com/questions/6402834/how-to-hide-desktop-icons-programmatically/
        public static void SetDesktopIconVisibility(bool isVisible)
        {
            //Does not work in Win10
            //NM.SHGetSetSettings(ref state, NM.SSF.SSF_HIDEICONS, true);

            if (GetDesktopIconVisibility() ^ isVisible) //XOR!!!
            {
                NM.SendMessage(GetDesktopSHELLDLL_DefView(), (int)NM.WM.COMMAND, (IntPtr)0x7402, IntPtr.Zero);
            }
        }

        private static IntPtr GetDesktopSHELLDLL_DefView()
        {
            IntPtr hShellViewWin = IntPtr.Zero;
            IntPtr hWorkerW = IntPtr.Zero;

            IntPtr hProgman = NM.FindWindow("Progman", "Program Manager");
            IntPtr hDesktopWnd = NM.GetDesktopWindow();

            // If the main Program Manager window is found
            if (hProgman != IntPtr.Zero)
            {
                // Get and load the main List view window containing the icons.
                hShellViewWin = NM.FindWindowEx(hProgman, IntPtr.Zero, "SHELLDLL_DefView", null);
                if (hShellViewWin == IntPtr.Zero)
                {
                    // When this fails (picture rotation is turned ON), then look for the WorkerW windows list to get the
                    // correct desktop list handle.
                    // As there can be multiple WorkerW windows, iterate through all to get the correct one
                    do
                    {
                        hWorkerW = NM.FindWindowEx(hDesktopWnd, hWorkerW, "WorkerW", null);
                        hShellViewWin = NM.FindWindowEx(hWorkerW, IntPtr.Zero, "SHELLDLL_DefView", null);
                    } while (hShellViewWin == IntPtr.Zero && hWorkerW != IntPtr.Zero);
                }
            }
            return hShellViewWin;
        }

        /// <summary>
        /// Force redraw desktop - clears wallpaper persisting on screen even after close.
        /// </summary>
        public static void RefreshDesktop()
        {
            //todo: Find a better way to do this?
            NM.SystemParametersInfo(NM.SPI_SETDESKWALLPAPER, 0, null, NM.SPIF_UPDATEINIFILE);
        }
    }
}