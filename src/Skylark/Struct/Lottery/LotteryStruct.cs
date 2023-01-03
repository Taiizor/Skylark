using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LotteryDrawStruct
    {
        public List<string> Winners;
        public List<string> Reserve;
    }
}