using System.IO.Compression;
using SECT = Skylark.Enum.CompressionType;

namespace Skylark.Standard.Manage.Compression
{
    /// <summary>
    /// 
    /// </summary>
    internal static class CompressionManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const SECT Type = SECT.GZip;

        /// <summary>
        /// 
        /// </summary>
        public const string Data = "Taiizor Skylark";

        /// <summary>
        /// 
        /// </summary>
        public const CompressionLevel Level = CompressionLevel.Optimal;
    }
}