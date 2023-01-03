using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WordDataStruct
    {
        public int Word;
        public int Char;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WordCombineStruct
    {
        public string Result;
        public int Count;
    }
}