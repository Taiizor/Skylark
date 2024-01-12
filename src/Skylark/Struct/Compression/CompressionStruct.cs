using System.Runtime.InteropServices;

namespace Skylark.Struct.Compression
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CompressionStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public int Length;
        /// <summary>
        /// 
        /// </summary>
        public string Data;
        /// <summary>
        /// 
        /// </summary>
        public int CompressedLength;
        /// <summary>
        /// 
        /// </summary>
        public int CompressionLength;
        /// <summary>
        /// 
        /// </summary>
        public byte[] CompressedData;
        /// <summary>
        /// 
        /// </summary>
        public double CompressionPercentage;
    }
}