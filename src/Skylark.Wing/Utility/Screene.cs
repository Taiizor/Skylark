using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using EAFT = Skylark.Enum.AncestorFlagsType;
using HFI = Skylark.Wing.Helper.FormInterop;
using HWAPI = Skylark.Wing.Helper.WinAPI;
using HWI = Skylark.Wing.Helper.WindowInterop;
using MI = Skylark.Manage.Internal;
using SMMS = Skylark.Struct.Monitor.MonitorStruct;
using SRRS = Skylark.Struct.Rectangles.RectanglesStruct;

namespace Skylark.Wing.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public static class Screene
    {
        /// <summary>
        /// 
        /// </summary>
        public static SMMS[] Screens { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        static Screene()
        {
            Initialize();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Initialize()
        {
            MI.CombinedRectangles = new SRRS(0, 0, 0, 0);

            List<SMMS> Screenes = new();

            bool CallBack(IntPtr hDesktop, IntPtr hdc, ref SRRS pRect, int d)
            {
                SMMS Info = new()
                {
                    cbSize = (sizeof(int) * 4 * 2) + (sizeof(int) * 2)
                };

                if (HWAPI.GetMonitorInfo(hDesktop, ref Info) == false)
                {
                    return false;
                }

                SRRS Rectangle = Info.rcMonitor;

                if (Rectangle.Left < MI.CombinedRectangles.Left)
                {
                    MI.CombinedRectangles.Left = Rectangle.Left;
                }

                if (Rectangle.Top < MI.CombinedRectangles.Top)
                {
                    MI.CombinedRectangles.Top = Rectangle.Top;
                }

                if (Rectangle.Right > MI.CombinedRectangles.Right)
                {
                    Rectangle.Right = MI.CombinedRectangles.Right;
                }

                if (Rectangle.Bottom > MI.CombinedRectangles.Bottom)
                {
                    Rectangle.Bottom = MI.CombinedRectangles.Bottom;
                }

                Screenes.Add(Info);

                return true;
            }

            if (HWAPI.EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, CallBack, 0))
            {
                Screens = Screenes.ToArray();
            }
            else
            {
                Screens = new[]
                {
                    new SMMS()
                    {
                        rcMonitor = Screen.PrimaryScreen.Bounds,
                        rcWork = Screen.PrimaryScreen.WorkingArea,
                    }
                };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
        /// <param name="Screen"></param>
        public static void FillScreenForm(Form Form, SMMS Screen)
        {
            SRRS Rectangle = Screen.rcMonitor; //Screen.rcWork;

            int X = Rectangle.Left - MI.CombinedRectangles.Left;
            int Y = Rectangle.Top - MI.CombinedRectangles.Top;

            HWAPI.MoveWindow(HFI.Handle(Form), X, Y, Rectangle.Width, Rectangle.Height, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <param name="Screen"></param>
        public static void FillScreenWindow(Window Window, SMMS Screen)
        {
            SRRS Rectangle = Screen.rcMonitor; //Screen.rcWork;

            int X = Rectangle.Left - MI.CombinedRectangles.Left;
            int Y = Rectangle.Top - MI.CombinedRectangles.Top;

            //Window.Left = X;
            //Window.Top = Y;
            //Window.Width = Rectangle.Width;
            //Window.Height = Rectangle.Height;

            //Window.ShowInTaskbar = false;
            Window.WindowStyle = WindowStyle.None;
            //Window.ResizeMode = ResizeMode.NoResize;

            //IntPtr hwnd = HWI.EnsureHandle(Window);
            //int exStyle = NM.GetWindowLong(hwnd, (int)NM.GWL.GWL_EXSTYLE);
            //NM.SetWindowLong(hwnd, (int)NM.GWL.GWL_EXSTYLE, exStyle | (int)NM.WindowStyles.WS_EX_NOACTIVATE);

            HWAPI.MoveWindow(HWI.EnsureHandle(Window), X, Y, Rectangle.Width, Rectangle.Height, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        public static bool IsOverlayedForm(Form Form)
        {
            // A list of class names to ignore even if fullscreen
            string[] ClassNamesExcluded =
            {
                "WorkerW", // Wallpapers
                "ProgMan", //Progman, Program Manager
                "ImmersiveLauncher" // Win8 Splash Screen
            };

            // Get the handle of the top-level control.
            IntPtr ForegroundWindow = HWAPI.GetForegroundWindow();

            if (ForegroundWindow == IntPtr.Zero)
            {
                return false;
            }

            ForegroundWindow = HWAPI.GetAncestor(ForegroundWindow, EAFT.GetRoot);

            // If you are yourself, you are not covered.
            if (ForegroundWindow == HFI.Handle(Form))
            {
                return false;
            }

            // Gets the control's class name.
            string ClassName = HWAPI.GetClassName(ForegroundWindow);

            if (ClassName.Length <= 0)
            {
                return false;
            }

            // Check if any of the exclusions apply.
            if (ClassNamesExcluded.Any((Name) => Name.ToUpper() == ClassName.ToUpper()))
            {
                return false;
            }

            // Retrieves the rectangular area of the monitor to which the current control belongs.
            SRRS Desktop;
            IntPtr Monitor = HWAPI.MonitorFromWindow(HFI.Handle(Form), MI.MONITOR_DEFAULTTONEAREST);

            if (Monitor == IntPtr.Zero)
            {
                // If the monitor cannot be found, it is set to the handle of the current window screen.
                IntPtr DesktopWnd = HWAPI.GetDesktopWindow();

                if (DesktopWnd == IntPtr.Zero)
                {
                    return false;
                }

                if (HWAPI.GetWindowRect(DesktopWnd, out Desktop) == false)
                {
                    return false;
                }
            }
            else
            {
                SMMS Info = new()
                {
                    cbSize = (sizeof(int) * 4 * 2) + (sizeof(int) * 2)
                };

                if (HWAPI.GetMonitorInfo(Monitor, ref Info) == false)
                {
                    return false;
                }

                Desktop = Info.rcMonitor;
            }

            // Retrieves the working area of a control.
            if (HWAPI.GetWindowRect(ForegroundWindow, out SRRS Client) == false)
            {
                return false;
            }

            // If a control doesn't fit completely on the monitor or is smaller than its size, it's not full screen.
            if (Client.Left > Desktop.Left + 1 || Client.Top > Desktop.Top + 1 || Client.Right < Desktop.Right - 1 || Client.Bottom < Desktop.Bottom - 1)
            {
                return false;
            }

            // If you've reached this point, you're in full screen.
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <returns></returns>
        public static bool IsOverlayedWindow(Window Window)
        {
            // A list of class names to ignore even if fullscreen
            string[] ClassNamesExcluded =
            {
                "WorkerW", // Wallpapers
                "ProgMan", //Progman, Program Manager
                "ImmersiveLauncher" // Win8 Splash Screen
            };

            // Get the handle of the top-level control.
            IntPtr ForegroundWindow = HWAPI.GetForegroundWindow();

            if (ForegroundWindow == IntPtr.Zero)
            {
                return false;
            }

            ForegroundWindow = HWAPI.GetAncestor(ForegroundWindow, EAFT.GetRoot);

            // If you are yourself, you are not covered.
            if (ForegroundWindow == HWI.EnsureHandle(Window))
            {
                return false;
            }

            // Gets the control's class name.
            string ClassName = HWAPI.GetClassName(ForegroundWindow);

            if (ClassName.Length <= 0)
            {
                return false;
            }

            // Check if any of the exclusions apply.
            if (ClassNamesExcluded.Any((Name) => Name.ToUpper() == ClassName.ToUpper()))
            {
                return false;
            }

            // Retrieves the rectangular area of the monitor to which the current control belongs.
            SRRS Desktop;
            IntPtr Monitor = HWAPI.MonitorFromWindow(HWI.EnsureHandle(Window), MI.MONITOR_DEFAULTTONEAREST);

            if (Monitor == IntPtr.Zero)
            {
                // If the monitor cannot be found, it is set to the handle of the current window screen.
                IntPtr DesktopWnd = HWAPI.GetDesktopWindow();

                if (DesktopWnd == IntPtr.Zero)
                {
                    return false;
                }

                if (HWAPI.GetWindowRect(DesktopWnd, out Desktop) == false)
                {
                    return false;
                }
            }
            else
            {
                SMMS Info = new()
                {
                    cbSize = (sizeof(int) * 4 * 2) + (sizeof(int) * 2)
                };

                if (HWAPI.GetMonitorInfo(Monitor, ref Info) == false)
                {
                    return false;
                }

                Desktop = Info.rcMonitor;
            }

            // Retrieves the working area of a control.
            if (HWAPI.GetWindowRect(ForegroundWindow, out SRRS Client) == false)
            {
                return false;
            }

            // If a control doesn't fit completely on the monitor or is smaller than its size, it's not full screen.
            if (Client.Left > Desktop.Left + 1 || Client.Top > Desktop.Top + 1 || Client.Right < Desktop.Right - 1 || Client.Bottom < Desktop.Bottom - 1)
            {
                return false;
            }

            // If you've reached this point, you're in full screen.
            return true;
        }
    }
}