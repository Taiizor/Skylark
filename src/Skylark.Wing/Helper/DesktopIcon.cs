using System;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using E = Skylark.Exception;
using ETFT = Skylark.Enum.TimeoutFlagsType;
using HFI = Skylark.Wing.Helper.FormInterop;
using HWAPI = Skylark.Wing.Helper.WinAPI;
using HWI = Skylark.Wing.Helper.WindowInterop;

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
                return FixHandle(HFI.Handle(Form));
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static bool FixWindow(Window Window)
        {
            try
            {
                return FixHandle(HWI.EnsureHandle(Window));
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handle"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static bool FixHandle(IntPtr Handle)
        {
            try
            {
                IntPtr Progman = HWAPI.FindWindow("Progman", null); //"Progman", "Program Manager"

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
                        HWAPI.SendMessageTimeout(Progman, 0x052C, new IntPtr(0), IntPtr.Zero, ETFT.SMTO_NORMAL, 10000, out Result);
                    }

                    HWAPI.EnumWindows(new HWAPI.EnumWindowsProc((TopHandle, TopParamHandle) =>
                    {
                        IntPtr IntPtr = HWAPI.FindWindowEx(TopHandle, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero);

                        if (IntPtr != IntPtr.Zero)
                        {
                            WorkerW = HWAPI.FindWindowEx(IntPtr.Zero, TopHandle, "WorkerW", IntPtr.Zero);
                        }

                        return true;
                    }), IntPtr.Zero);


                    if (WorkerW == IntPtr.Zero)
                    {
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        break;
                    }
                }

                if (WorkerW == IntPtr.Zero)
                {
                    return false;
                }

                HWAPI.ShowWindow(WorkerW, 0); /*HIDE*/
                HWAPI.SetParent(Handle, Progman);

                return true;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}