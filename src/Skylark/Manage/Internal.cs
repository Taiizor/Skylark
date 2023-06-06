namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    public static class Internal
    {
        /// <summary>
        /// 
        /// </summary>
        public const int PathLength = 1024;

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
        /// 2 GB = 2147483648 Byte
        /// 3 GB = 3221225472 Byte
        /// 4 GB = 4294967296 Byte
        /// 5 GB = 5368709120 Byte
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