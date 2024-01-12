namespace Skylark.Enum
{
    /// <summary>
    /// 
    /// </summary>
    public enum DecompressionType
    {
        /// <summary>
        /// 
        /// </summary>
        GZip,
#if NETSTANDARD2_1
        /// <summary>
        /// 
        /// </summary>
        Brotli,
#endif
        /// <summary>
        /// 
        /// </summary>
        Deflate
    }
}