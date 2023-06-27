using System;
using System.Drawing;

namespace Skylark.Wing.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDisplayMonitor : IEquatable<IDisplayMonitor>
    {
        Rectangle Bounds { get; }

        string DeviceId { get; }

        string DeviceName { get; }

        string DisplayName { get; }

        IntPtr HMonitor { get; }

        int Index { get; }

        bool IsPrimary { get; }

        Rectangle WorkingArea { get; }
    }
}