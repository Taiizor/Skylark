using System.Runtime.InteropServices;
using ESTT = Skylark.Enum.ShortTimeType;
using ETT = Skylark.Enum.TimeType;

namespace Skylark.Struct.Time
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct TimeStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public double Value;
        /// <summary>
        /// 
        /// </summary>
        public string Text;
        /// <summary>
        /// 
        /// </summary>
        public ESTT Short;
        /// <summary>
        /// 
        /// </summary>
        public ETT Type;
    }
}