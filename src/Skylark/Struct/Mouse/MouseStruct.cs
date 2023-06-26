using System.Runtime.InteropServices;

namespace Skylark.Struct.Mouse
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MousePointStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public int X;
        /// <summary>
        /// 
        /// </summary>
        public int Y;
    }

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseHookStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public MousePointStruct pt;
        /// <summary>
        /// 
        /// </summary>
        public IntPtr hwnd;
        /// <summary>
        /// 
        /// </summary>
        public uint wHitTestCode;
        /// <summary>
        /// 
        /// </summary>
        public IntPtr dwExtraInfo;
    }

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseExtraHookStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public MousePointStruct Point;
        /// <summary>
        /// 
        /// </summary>
        public int MouseData;
        /// <summary>
        /// 
        /// </summary>
        public int Flags;
        /// <summary>
        /// 
        /// </summary>
        public int Time;
        /// <summary>
        /// 
        /// </summary>
        public IntPtr ExtraInfo;
    }
}