using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WordDataStruct
    {
        public int Word;
        public int Char;
    }

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WordCombineStruct
    {
        public string Result;
        public int Count;
    }
}