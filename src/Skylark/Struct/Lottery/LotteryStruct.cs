using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LotteryDrawStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> Winners;
        /// <summary>
        /// 
        /// </summary>
        public List<string> Reserve;
    }
}