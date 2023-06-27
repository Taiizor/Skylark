using Skylark.Struct.Mouse;
using Skylark.Wing.Interface;
using Skylark.Wing.Native;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class DisplayManager : IDisplayManager
    {
        private const int PRIMARY_MONITOR = unchecked((int)0xBAADF00D);

        private const int MONITORINFOF_PRIMARY = 0x00000001;
        private const int MONITOR_DEFAULTTONEAREST = 0x00000002;

        private static bool multiMonitorSupport;
        private const string defaultDisplayDeviceName = "DISPLAY";

        //public static DisplayManager Instance { get; private set; }

        public event EventHandler DisplayUpdated;

        public ObservableCollection<DisplayMonitor> DisplayMonitors { get; } = new ObservableCollection<DisplayMonitor>();

        private Rectangle virtualScreenBounds = Rectangle.Empty;

        public Rectangle VirtualScreenBounds
        {
            get => virtualScreenBounds;
            private set => virtualScreenBounds = value;
        }

        public DisplayMonitor PrimaryDisplayMonitor => DisplayMonitors.FirstOrDefault(x => x.IsPrimary);

        public DisplayManager()
        {
            RefreshDisplayMonitorList();
        }


        //public static void Initialize()
        //{
        //    Instance = new DisplayManager();
        //}


        public uint OnHwndCreated(IntPtr hWnd, out bool register)
        {
            register = false;
            return 0;
        }

        public IntPtr OnWndProc(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            if (msg == (uint)Methods.WM.DISPLAYCHANGE) //|| (msg == (uint)Methods.WM.SETTINGCHANGE && wParam == ((IntPtr)Methods.SPI.SPI_SETWORKAREA)))
            {
                RefreshDisplayMonitorList();
            }

            return IntPtr.Zero;
        }

        public DisplayMonitor GetDisplayMonitorFromHWnd(IntPtr hWnd)
        {
            IntPtr hMonitor = multiMonitorSupport ? Methods.MonitorFromWindow(new HandleRef(null, hWnd), MONITOR_DEFAULTTONEAREST) : (IntPtr)PRIMARY_MONITOR;

            return GetDisplayMonitorFromHMonitor(hMonitor);
        }

        public DisplayMonitor GetDisplayMonitorFromPoint(Point point)
        {
            IntPtr hMonitor;
            if (multiMonitorSupport)
            {
                Methods.POINT pt = new(  //POINTSTRUCT
                    (int)Math.Round((double)point.X),
                    (int)Math.Round((double)point.Y));
                hMonitor = Methods.MonitorFromPoint(pt, MONITOR_DEFAULTTONEAREST);
            }
            else
            {
                hMonitor = (IntPtr)PRIMARY_MONITOR;
            }

            return GetDisplayMonitorFromHMonitor(hMonitor);
        }

        public DisplayMonitor GetDisplayMonitorFromPoint(MouseHookStruct mouse)
        {
            return GetDisplayMonitorFromPoint(new Point() { X = mouse.pt.X, Y = mouse.pt.Y });
        }

        public DisplayMonitor GetDisplayMonitorFromPoint(MouseExtraHookStruct mouse)
        {
            return GetDisplayMonitorFromPoint(new Point() { X = mouse.Point.X, Y = mouse.Point.Y });
        }

        private void RefreshDisplayMonitorList()
        {
            multiMonitorSupport = Methods.GetSystemMetrics((int)Methods.SystemMetric.SM_CMONITORS) != 0;

            IList<IntPtr> hMonitors = GetHMonitors();

            foreach (DisplayMonitor displayMonitor in DisplayMonitors)
            {
                displayMonitor.isStale = true;
            }

            for (int i = 0; i < hMonitors.Count; i++)
            {
                DisplayMonitor displayMonitor = GetDisplayMonitorFromHMonitor(hMonitors[i]);
                displayMonitor.Index = i + 1;
            }

            List<DisplayMonitor> staleDisplayMonitors = DisplayMonitors.Where(x => x.isStale).ToList();

            foreach (DisplayMonitor displayMonitor in staleDisplayMonitors)
            {
                DisplayMonitors.Remove(displayMonitor);
            }

            staleDisplayMonitors.Clear();
            staleDisplayMonitors = null;

            VirtualScreenBounds = GetVirtualScreenBounds();

            DisplayUpdated?.Invoke(this, EventArgs.Empty);
        }

        private DisplayMonitor GetDisplayMonitorFromHMonitor(IntPtr hMonitor)
        {
            DisplayMonitor displayMonitor = null;

            if (!multiMonitorSupport || hMonitor == (IntPtr)PRIMARY_MONITOR)
            {
                displayMonitor = GetDisplayMonitorByDeviceName(defaultDisplayDeviceName);

                if (displayMonitor == null)
                {
                    displayMonitor = new DisplayMonitor(defaultDisplayDeviceName);
                    DisplayMonitors.Add(displayMonitor);
                }

                displayMonitor.Bounds = GetVirtualScreenBounds();
                displayMonitor.DeviceId = GetDefaultDisplayDeviceId();
                displayMonitor.DisplayName = "Display";
                displayMonitor.HMonitor = hMonitor;
                displayMonitor.IsPrimary = true;
                displayMonitor.WorkingArea = GetWorkingArea();

                displayMonitor.isStale = false;
            }
            else
            {
                Methods.MONITORINFOEX info = new();// MONITORINFOEX();
                Methods.GetMonitorInfo(new HandleRef(null, hMonitor), info);

                string deviceName = new string(info.szDevice).TrimEnd((char)0);

                displayMonitor = GetDisplayMonitorByDeviceName(deviceName);

                displayMonitor ??= CreateDisplayMonitorFromMonitorInfo(deviceName);

                displayMonitor.HMonitor = hMonitor;

                UpdateDisplayMonitor(displayMonitor, info);
            }

            return displayMonitor;
        }

        private DisplayMonitor GetDisplayMonitorByDeviceName(string deviceName)
        {
            return DisplayMonitors.FirstOrDefault(x => x.DeviceName == deviceName);
        }

        private DisplayMonitor CreateDisplayMonitorFromMonitorInfo(string deviceName)
        {
            DisplayMonitor displayMonitor = new(deviceName);

            Methods.DISPLAY_DEVICE displayDevice = GetDisplayDevice(deviceName);
            displayMonitor.DeviceId = displayDevice.DeviceID;
            displayMonitor.DisplayName = displayDevice.DeviceString;

            DisplayMonitors.Add(displayMonitor);

            return displayMonitor;
        }

        private void UpdateDisplayMonitor(DisplayMonitor displayMonitor, Methods.MONITORINFOEX info)
        {
            displayMonitor.Bounds = new Rectangle(
                info.rcMonitor.Left, info.rcMonitor.Top,
                info.rcMonitor.Right - info.rcMonitor.Left,
                info.rcMonitor.Bottom - info.rcMonitor.Top);

            displayMonitor.IsPrimary = (info.dwFlags & MONITORINFOF_PRIMARY) != 0;

            displayMonitor.WorkingArea = new Rectangle(
                info.rcWork.Left, info.rcWork.Top,
                info.rcWork.Right - info.rcWork.Left,
                info.rcWork.Bottom - info.rcWork.Top);

            displayMonitor.isStale = false;
        }

        private IList<IntPtr> GetHMonitors()
        {
            if (multiMonitorSupport)
            {
                List<IntPtr> hMonitors = new();

                bool callback(IntPtr monitor, IntPtr hdc, IntPtr lprcMonitor, IntPtr lParam)
                {
                    hMonitors.Add(monitor);
                    return true;
                }

                Methods.EnumDisplayMonitors(new HandleRef(null, IntPtr.Zero), null, callback, IntPtr.Zero);

                return hMonitors;
            }

            return new[] { (IntPtr)PRIMARY_MONITOR };
        }

        private static Methods.DISPLAY_DEVICE GetDisplayDevice(string deviceName)
        {
            Methods.DISPLAY_DEVICE result = new();

            Methods.DISPLAY_DEVICE displayDevice = new();
            displayDevice.cb = Marshal.SizeOf(displayDevice);

            try
            {
                for (uint id = 0; Methods.EnumDisplayDevices(deviceName, id, ref displayDevice, Methods.EDD_GET_DEVICE_INTERFACE_NAME); id++)
                {
                    if (displayDevice.StateFlags.HasFlag(Methods.DisplayDeviceStateFlags.AttachedToDesktop)
                        && !displayDevice.StateFlags.HasFlag(Methods.DisplayDeviceStateFlags.MirroringDriver))
                    {
                        result = displayDevice;
                        break;
                    }

                    displayDevice.cb = Marshal.SizeOf(displayDevice);
                }
            }
            catch { }

            if (string.IsNullOrEmpty(result.DeviceID)
                || string.IsNullOrWhiteSpace(result.DeviceID))
            {
                result.DeviceID = GetDefaultDisplayDeviceId();
            }

            return result;
        }

        private static string GetDefaultDisplayDeviceId()
        {
            return Methods.GetSystemMetrics((int)Methods.SystemMetric.SM_REMOTESESSION) != 0 ? "\\\\?\\DISPLAY#REMOTEDISPLAY#" : "\\\\?\\DISPLAY#LOCALDISPLAY#";
        }

        private static Rectangle GetVirtualScreenBounds()
        {
            Point location = new(Methods.GetSystemMetrics((int)Methods.SystemMetric.SM_XVIRTUALSCREEN), Methods.GetSystemMetrics((int)Methods.SystemMetric.SM_YVIRTUALSCREEN));

            Size size = new(Methods.GetSystemMetrics((int)Methods.SystemMetric.SM_CXVIRTUALSCREEN), Methods.GetSystemMetrics((int)Methods.SystemMetric.SM_CYVIRTUALSCREEN));

            return new Rectangle(location, size);
        }

        private static Rectangle GetWorkingArea()
        {
            Methods.RECT rc = new();
            Methods.SystemParametersInfo((int)Methods.SPI.SPI_GETWORKAREA, 0, ref rc, 0);
            return new Rectangle(rc.Left, rc.Top, rc.Right - rc.Left, rc.Bottom - rc.Top);
        }

        public bool ScreenExists(IDisplayMonitor display)
        {
            return DisplayMonitors.Any(display.Equals);
        }

        public bool IsMultiScreen()
        {
            return DisplayMonitors.Count > 1;
        }
    }
}