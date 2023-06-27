using Skylark.Wing.Interface;
using System;
using System.Drawing;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class DisplayMonitor : IDisplayMonitor
    {
        public bool isStale;

        #region Properties

        private Rectangle bounds = Rectangle.Empty;

        public Rectangle Bounds
        {
            get => bounds;
            set => bounds = value;
        }

        public string DeviceId { get; set; } = string.Empty;
        public string DeviceName { get; set; } = string.Empty;

        public string DisplayName { get; set; } = string.Empty;

        public IntPtr HMonitor { get; set; } = IntPtr.Zero;

        public int Index { get; set; }

        public bool IsPrimary { get; set; }

        private Rectangle workingArea = Rectangle.Empty;

        public Rectangle WorkingArea
        {
            get => workingArea;
            set => workingArea = value;
        }

        #endregion

        public DisplayMonitor(string deviceName)
        {
            DeviceName = deviceName;
        }

        public DisplayMonitor()
        { }

        public bool Equals(IDisplayMonitor other)
        {
            return other.DeviceId == this.DeviceId;
        }
    }
}
