using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using SE = Skylark.Exception;
using SETFT = Skylark.Enum.TimeoutFlagsType;
using SWHFI = Skylark.Wing.Helper.FormInterop;
using SWHPI = Skylark.Wing.Helper.ProcessInterop;
using SWHWAPI = Skylark.Wing.Helper.WinAPI;
using SWHWI = Skylark.Wing.Helper.WindowInterop;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class DesktopIcon
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        public static bool FixForm(Form Form)
        {
            try
            {
                return FixHandle(SWHFI.Handle(Form));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static bool FixWindow(Window Window)
        {
            try
            {
                return FixHandle(SWHWI.EnsureHandle(Window));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static bool FixProcess(Process Process)
        {
            try
            {
                return FixHandle(SWHPI.MainWindowHandle(Process));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handle"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static bool FixHandle(IntPtr Handle)
        {
            try
            {
                IntPtr Progman = SWHWAPI.FindWindow("Progman", "Program Manager"); //"Progman", null - "Progman", "Program Manager"

                if (Progman == IntPtr.Zero)
                {
                    return false;
                }

                IntPtr WorkerW = IntPtr.Zero;

                // Tried several times.
                for (int Count = 0; Count < 8; ++Count)
                {
                    // Skip once.
                    if (Count % 2 == 0)
                    {
                        IntPtr Result = IntPtr.Zero;
                        SWHWAPI.SendMessageTimeout(Progman, 0x052C, new IntPtr(0xD), new IntPtr(0x1), SETFT.SMTO_NORMAL, 10000, out Result);
                    }

                    SWHWAPI.EnumWindows(new SWHWAPI.EnumWindowsProc((TopHandle, TopParamHandle) =>
                    {
                        IntPtr IntPtr = SWHWAPI.FindWindowEx(TopHandle, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero);

                        if (IntPtr != IntPtr.Zero)
                        {
                            WorkerW = SWHWAPI.FindWindowEx(IntPtr.Zero, TopHandle, "WorkerW", IntPtr.Zero);
                        }

                        return true;
                    }), IntPtr.Zero);

                    if (WorkerW == IntPtr.Zero)
                    {
                        Thread.Sleep(250);
                    }
                    else
                    {
                        break;
                    }
                }

                // Some Windows 11 builds have a different Progman window layout.
                // If the above code failed to find WorkerW, we should try this.
                // Spy++ output
                // 0x000100EC "Program Manager" Progman
                //   0x000100EE "" SHELLDLL_DefView
                //     0x000100F0 "FolderView" SysListView32
                //   0x00100B8A "" WorkerW       <-- This is the WorkerW instance we are after!
                if (WorkerW == IntPtr.Zero)
                {
                    WorkerW = SWHWAPI.FindWindowEx(Progman, IntPtr.Zero, "WorkerW", IntPtr.Zero);
                }

                if (WorkerW == IntPtr.Zero)
                {
                    return false;
                }

                return SetParent(Handle, Progman, WorkerW);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        private static bool SetParent(IntPtr Handle, IntPtr Progman, IntPtr WorkerW)
        {
            //Win7
            if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1)
            {
                if (!WorkerW.Equals(Progman))
                {
                    SWNM.ShowWindow(WorkerW, 0);
                }

                IntPtr Return = SWNM.SetParent(Handle, Progman);

                if (Return.Equals(IntPtr.Zero))
                {
                    return false;
                }

                WorkerW = Progman;
            }
            else
            {
                IntPtr Return = SWNM.SetParent(Handle, WorkerW);

                if (Return.Equals(IntPtr.Zero))
                {
                    return false;
                }
            }

            //SWHWAPI.ShowWindow(WorkerW, 0); /*HIDE*/
            //SWHWAPI.SetParent(Handle, Progman);

            return true;
        }
    }
}