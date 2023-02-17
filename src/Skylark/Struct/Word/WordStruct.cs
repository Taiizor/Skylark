using System.Runtime.InteropServices;

namespace Skylark.Struct.Word
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WordDataStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public int Word;
        /// <summary>
        /// 
        /// </summary>
        public int Char;
    }

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WordCombineStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public string Result;
        /// <summary>
        /// 
        /// </summary>
        public int Count;
    }
}