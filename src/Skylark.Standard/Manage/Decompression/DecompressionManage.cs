using System.IO.Compression;
using SEDT = Skylark.Enum.DecompressionType;

namespace Skylark.Standard.Manage.Decompression
{
    /// <summary>
    /// 
    /// </summary>
    internal static class DecompressionManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const SEDT Type = SEDT.GZip;

        /// <summary>
        /// 
        /// </summary>
        public const CompressionLevel Level = CompressionLevel.Optimal;

        /// <summary>
        /// 
        /// </summary>
        public const string Length = "Data size is too large.";
    }
}