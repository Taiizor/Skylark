using Skylark.Struct.Mouse;
using Skylark.Wing.Helper;
using System;
using System.Collections.ObjectModel;
using System.Drawing;

namespace Skylark.Wing.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDisplayManager
    {
        ObservableCollection<DisplayMonitor> DisplayMonitors { get; }

        DisplayMonitor PrimaryDisplayMonitor { get; }

        Rectangle VirtualScreenBounds { get; }

        event EventHandler DisplayUpdated;

        DisplayMonitor GetDisplayMonitorFromHWnd(IntPtr hWnd);

        DisplayMonitor GetDisplayMonitorFromPoint(Point point);

        DisplayMonitor GetDisplayMonitorFromPoint(MouseHookStruct mouse);

        DisplayMonitor GetDisplayMonitorFromPoint(MouseExtraHookStruct mouse);

        bool IsMultiScreen();

        uint OnHwndCreated(IntPtr hWnd, out bool register);

        IntPtr OnWndProc(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);

        bool ScreenExists(IDisplayMonitor display);
    }
}