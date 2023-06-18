using System;
using System.Threading;
using E = Skylark.Exception;
using ETF = Skylark.Enum.TimeoutFlags;
using HWAPI = Skylark.Wing.Helper.WinAPI;

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
        /// <param name="FormHandle"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static bool Fix(IntPtr FormHandle)
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
                        HWAPI.SendMessageTimeout(Progman, 0x052C, new IntPtr(0), IntPtr.Zero, ETF.SMTO_NORMAL, 10000, out Result);
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
                HWAPI.SetParent(FormHandle, Progman);

                return true;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}