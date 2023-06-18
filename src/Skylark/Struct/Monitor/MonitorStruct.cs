using System.Runtime.InteropServices;
using SRRS = Skylark.Struct.Rectangles.RectanglesStruct;

namespace Skylark.Struct.Monitor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MonitorStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public int cbSize;
        /// <summary>
        /// 
        /// </summary>
        public SRRS rcMonitor;
        /// <summary>
        /// 
        /// </summary>
        public SRRS rcWork;
        /// <summary>
        /// 
        /// </summary>
        public uint dwFlags;
    }
}