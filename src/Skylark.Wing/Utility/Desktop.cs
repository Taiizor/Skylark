using System;
using System.Text;
using SWNM = Skylark.Wing.Native.Methods;

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
            SWNM.SHELLSTATE state = new();
            SWNM.SHGetSetSettings(ref state, SWNM.SSF.SSF_HIDEICONS, false); //get state
            return !state.fHideIcons;
        }

        //ref: https://stackoverflow.com/questions/6402834/how-to-hide-desktop-icons-programmatically/
        public static void SetDesktopIconVisibility(bool isVisible)
        {
            //Does not work in Win10
            //SWNM.SHGetSetSettings(ref state, SWNM.SSF.SSF_HIDEICONS, true);

            if (GetDesktopIconVisibility() ^ isVisible) //XOR!!!
            {
                SWNM.SendMessage(GetDesktopSHELLDLL_DefView(), (int)SWNM.WM.COMMAND, (IntPtr)0x7402, IntPtr.Zero);
            }
        }

        private static IntPtr GetDesktopSHELLDLL_DefView()
        {
            IntPtr hShellViewWin = IntPtr.Zero;
            IntPtr hWorkerW = IntPtr.Zero;

            IntPtr hProgman = SWNM.FindWindow("Progman", "Program Manager");
            IntPtr hDesktopWnd = SWNM.GetDesktopWindow();

            // If the main Program Manager window is found
            if (hProgman != IntPtr.Zero)
            {
                // Get and load the main List view window containing the icons.
                hShellViewWin = SWNM.FindWindowEx(hProgman, IntPtr.Zero, "SHELLDLL_DefView", null);

                if (hShellViewWin == IntPtr.Zero)
                {
                    // When this fails (picture rotation is turned ON), then look for the WorkerW windows list to get the
                    // correct desktop list handle.
                    // As there can be multiple WorkerW windows, iterate through all to get the correct one
                    do
                    {
                        hWorkerW = SWNM.FindWindowEx(hDesktopWnd, hWorkerW, "WorkerW", null);
                        hShellViewWin = SWNM.FindWindowEx(hWorkerW, IntPtr.Zero, "SHELLDLL_DefView", null);
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
            SWNM.SystemParametersInfo(SWNM.SPI_SETDESKWALLPAPER, 0, null, SWNM.SPIF_UPDATEINIFILE);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool IsDesktopBasic()
        {
            IntPtr fHandle = SWNM.GetForegroundWindow();

            const int MaxChars = 256;

            StringBuilder ClassName = new(MaxChars);
            SWNM.GetClassName((int)fHandle, ClassName, MaxChars);

            return ClassName.ToString() is "WorkerW" or "SHELLDLL_DefView";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool IsDesktopAdvanced()
        {
            IntPtr workerWOrig = IntPtr.Zero;
            IntPtr progman = SWNM.FindWindow("Progman", null);
            IntPtr folderView = SWNM.FindWindowEx(progman, IntPtr.Zero, "SHELLDLL_DefView", null);

            if (folderView == IntPtr.Zero)
            {
                //If the desktop isn't under Progman, cycle through the WorkerW handles and find the correct one
                do
                {
                    workerWOrig = SWNM.FindWindowEx(SWNM.GetDesktopWindow(), workerWOrig, "WorkerW", null);
                    folderView = SWNM.FindWindowEx(workerWOrig, IntPtr.Zero, "SHELLDLL_DefView", null);
                } while (folderView == IntPtr.Zero && workerWOrig != IntPtr.Zero);
            }
            //else
            //{
            //    //If the desktop is under Progman, cycle through the WorkerW handles and find the correct one
            //    do
            //    {
            //        workerWOrig = SWNM.FindWindowEx(SWNM.GetDesktopWindow(), workerWOrig, "WorkerW", null);
            //        folderView = SWNM.FindWindowEx(workerWOrig, IntPtr.Zero, "SHELLDLL_DefView", null);
            //    } while (folderView != IntPtr.Zero && workerWOrig != IntPtr.Zero);
            //}

            IntPtr fHandle = SWNM.GetForegroundWindow();

            return Equals(fHandle, workerWOrig) || Equals(fHandle, progman);
        }
    }
}