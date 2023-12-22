using System.Runtime.InteropServices;

namespace Skylark.Struct.Browser
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BrowserStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public string Robot;
        /// <summary>
        /// 
        /// </summary>
        public bool RobotIs;
        /// <summary>
        /// 
        /// </summary>
        public string Mobile;
        /// <summary>
        /// 
        /// </summary>
        public bool MobileIs;
        /// <summary>
        /// 
        /// </summary>
        public string Browser;
        /// <summary>
        /// 
        /// </summary>
        public bool BrowserIs;
        /// <summary>
        /// 
        /// </summary>
        public string Platform;
        /// <summary>
        /// 
        /// </summary>
        public string BrowserVersion;
    }
}