using System.Runtime.InteropServices;

namespace Skylark.Struct.Decompression
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DecompressionStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public int Length;
        /// <summary>
        /// 
        /// </summary>
        public byte[] Data;
        /// <summary>
        /// 
        /// </summary>
        public int DecompressedLength;
        /// <summary>
        /// 
        /// </summary>
        public string DecompressedData;
        /// <summary>
        /// 
        /// </summary>
        public int DecompressionLength;
        /// <summary>
        /// 
        /// </summary>
        public double DecompressionPercentage;
    }
}