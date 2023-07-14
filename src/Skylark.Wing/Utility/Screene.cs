using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using HFI = Skylark.Wing.Helper.FormInterop;
using HPI = Skylark.Wing.Helper.ProcessInterop;
using HWAPI = Skylark.Wing.Helper.WinAPI;
using HWI = Skylark.Wing.Helper.WindowInterop;
using MI = Skylark.Manage.Internal;
using SEAFT = Skylark.Enum.AncestorFlagsType;
using SEST = Skylark.Enum.ScreenType;
using SMMS = Skylark.Struct.Monitor.MonitorStruct;
using SSRRS = Skylark.Struct.Rectangles.RectanglesStruct;

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
            MI.CombinedRectangles = new SSRRS(0, 0, 0, 0);

            List<SMMS> Screenes = new();

            bool CallBack(IntPtr hDesktop, IntPtr hdc, ref SSRRS pRect, int d)
            {
                SMMS Info = new()
                {
                    cbSize = (sizeof(int) * 4 * 2) + (sizeof(int) * 2)
                };

                if (HWAPI.GetMonitorInfo(hDesktop, ref Info) == false)
                {
                    return false;
                }

                SSRRS Rectangle = Info.rcMonitor;

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
        /// <param name="Type"></param>
        public static void FillScreenForm(Form Form, SMMS Screen, SEST Type)
        {
            SSRRS Rectangle = Type switch
            {
                SEST.WorkingArea => Screen.rcWork,
                _ => Screen.rcMonitor,
            };

            int X = Rectangle.Left - MI.CombinedRectangles.Left;
            int Y = Rectangle.Top - MI.CombinedRectangles.Top;

            if (Form.FormBorderStyle != FormBorderStyle.None)
            {
                Form.FormBorderStyle = FormBorderStyle.None;

                Form.Update();
                Form.Invalidate();
            }

            HWAPI.MoveWindow(HFI.Handle(Form), X, Y, Rectangle.Width, Rectangle.Height, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <param name="Screen"></param>
        /// <param name="Type"></param>
        public static void FillScreenWindow(Window Window, SMMS Screen, SEST Type)
        {
            SSRRS Rectangle = Type switch
            {
                SEST.WorkingArea => Screen.rcWork,
                _ => Screen.rcMonitor,
            };

            int X = Rectangle.Left - MI.CombinedRectangles.Left;
            int Y = Rectangle.Top - MI.CombinedRectangles.Top;

            //Window.Left = X;
            //Window.Top = Y;
            //Window.Width = Rectangle.Width;
            //Window.Height = Rectangle.Height;

            //Window.ShowInTaskbar = false;

            if (Window.WindowStyle != WindowStyle.None || Window.ResizeMode != ResizeMode.NoResize)
            {
                Window.WindowStyle = WindowStyle.None;
                Window.ResizeMode = ResizeMode.NoResize;

                Window.UpdateLayout();
                Window.InvalidateVisual();
            }

            //IntPtr hwnd = HWI.EnsureHandle(Window);
            //int exStyle = Methods.GetWindowLong(hwnd, (int)Methods.GWL.GWL_EXSTYLE);
            //Methods.SetWindowLong(hwnd, (int)Methods.GWL.GWL_EXSTYLE, exStyle | (int)Methods.WindowStyles.WS_EX_NOACTIVATE);

            HWAPI.MoveWindow(HWI.EnsureHandle(Window), X, Y, Rectangle.Width, Rectangle.Height, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <param name="Screen"></param>
        /// <param name="Type"></param>
        public static void FillScreenProcess(Process Process, SMMS Screen, SEST Type)
        {
            SSRRS Rectangle = Type switch
            {
                SEST.WorkingArea => Screen.rcWork,
                _ => Screen.rcMonitor,
            };

            int X = Rectangle.Left - MI.CombinedRectangles.Left;
            int Y = Rectangle.Top - MI.CombinedRectangles.Top;

            //IntPtr hwnd = HPI.MainWindowHandle(Process);
            //int exStyle = Methods.GetWindowLong(hwnd, (int)Methods.GWL.GWL_EXSTYLE);
            //Methods.SetWindowLong(hwnd, (int)Methods.GWL.GWL_EXSTYLE, exStyle | (int)Methods.WindowStyles.WS_EX_NOACTIVATE);

            HWAPI.MoveWindow(HPI.MainWindowHandle(Process), X, Y, Rectangle.Width, Rectangle.Height, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="Screen"></param>
        /// <param name="Type"></param>
        public static void FillScreenHandle(IntPtr Handle, SMMS Screen, SEST Type)
        {
            SSRRS Rectangle = Type switch
            {
                SEST.WorkingArea => Screen.rcWork,
                _ => Screen.rcMonitor,
            };

            int X = Rectangle.Left - MI.CombinedRectangles.Left;
            int Y = Rectangle.Top - MI.CombinedRectangles.Top;

            //int exStyle = Methods.GetWindowLong(Handle, (int)Methods.GWL.GWL_EXSTYLE);
            //Methods.SetWindowLong(Handle, (int)Methods.GWL.GWL_EXSTYLE, exStyle | (int)Methods.WindowStyles.WS_EX_NOACTIVATE);

            HWAPI.MoveWindow(Handle, X, Y, Rectangle.Width, Rectangle.Height, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        public static bool IsOverlayedForm(Form Form)
        {
            return IsOverlayedHandle(HFI.Handle(Form));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <returns></returns>
        public static bool IsOverlayedWindow(Window Window)
        {
            return IsOverlayedHandle(HWI.EnsureHandle(Window));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        public static bool IsOverlayedProcess(Process Process)
        {
            return IsOverlayedHandle(HPI.MainWindowHandle(Process));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handle"></param>
        /// <returns></returns>
        private static bool IsOverlayedHandle(IntPtr Handle)
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

            ForegroundWindow = HWAPI.GetAncestor(ForegroundWindow, SEAFT.GetRoot);

            // If you are yourself, you are not covered.
            if (ForegroundWindow == Handle)
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
            SSRRS Desktop;

            IntPtr Monitor = HWAPI.MonitorFromWindow(Handle, MI.MONITOR_DEFAULTTONEAREST);

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
            if (HWAPI.GetWindowRect(ForegroundWindow, out SSRRS Client) == false)
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