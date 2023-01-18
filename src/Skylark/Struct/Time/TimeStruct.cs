using System.Runtime.InteropServices;
using ETT = Skylark.Enum.TimeType;

namespace Skylark.Struct
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
        public decimal Value;
        /// <summary>
        /// 
        /// </summary>
        public string Text;
        /// <summary>
        /// 
        /// </summary>
        public ETT Type;
    }
}