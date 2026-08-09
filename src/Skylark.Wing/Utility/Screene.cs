using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using HFI = Skylark.Wing.Helper.FormInterop;
using HPI = Skylark.Wing.Helper.ProcessInterop;
using HWAPI = Skylark.Wing.Helper.WinAPI;
using HWI = Skylark.Wing.Helper.WindowInterop;
using MI = Skylark.Manage.Internal;
using SEAFT = Skylark.Enum.AncestorFlagsType;
using SEST = Skylark.Enum.ScreenType;
using SMMS = Skylark.Struct.Monitor.MonitorStruct;
using SSRRS = Skylark.Struct.Rectangles.RectanglesStruct;
using SWNM = Skylark.Wing.Native.Methods;

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

            List<SMMS> Screenes = [];

            bool CallBack(IntPtr hDesktop, IntPtr hdc, ref SSRRS pRect, int d)
            {
                SMMS Info = new()
                {
                    cbSize = Marshal.SizeOf<SMMS>()
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
                    MI.CombinedRectangles.Right = Rectangle.Right;
                }

                if (Rectangle.Bottom > MI.CombinedRectangles.Bottom)
                {
                    MI.CombinedRectangles.Bottom = Rectangle.Bottom;
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
                        cbSize = Marshal.SizeOf<SMMS>(),
                        rcMonitor = Screen.PrimaryScreen.Bounds,
                        rcWork = Screen.PrimaryScreen.WorkingArea,
                        szDevice = Screen.PrimaryScreen.DeviceName,
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

            IntPtr Handle = HWI.EnsureHandle(Window);

            HWAPI.MoveWindow(Handle, X, Y, Rectangle.Width, Rectangle.Height, false);

            // The wallpaper window is re-parented to the desktop WorkerW, so it stops
            // receiving WM_DPICHANGED and keeps rendering its content at its creation-time
            // DPI. On scaled (2K/4K) monitors this makes the content oversized and cropped,
            // so compensate the content scale by the target monitor DPI. No-op at 96 DPI.
            if (Window.Content is FrameworkElement Element)
            {
                int DPI = SWNM.GetDpiForWindow(Handle);

                if (DPI is > 0 and not 96)
                {
                    double Scale = 96.0 / DPI;

                    Element.LayoutTransform = new ScaleTransform(Scale, Scale);
                }
                else
                {
                    Element.LayoutTransform = Transform.Identity;
                }
            }
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