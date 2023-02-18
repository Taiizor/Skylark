namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Internal
    {
        /// <summary>
        /// 
        /// </summary>
        public const int TextLength = 1000000;

        /// <summary>
        /// 
        /// </summary>
        public const int ParameterLength = 64;

        /// <summary>
        /// 1 GB = 1073741824 Byte
        /// </summary>
        public const long FileLength = 1073741824;

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SplitSpace = new string[] { " " };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SplitNewLine = new string[] { "\r\n", "\r", "\n" };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SplitSpaceNewLine = new string[] { "\r\n", "\r", "\n", " " };
    }
}