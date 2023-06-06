namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    public static class External
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly Configuration Configuration = new()
        {
            PathLength = Internal.PathLength,
            TextLength = Internal.TextLength,
            ParameterLength = Internal.ParameterLength,
            FileLength = Internal.FileLength,
            SplitSpace = Internal.SplitSpace,
            SplitNewLine = Internal.SplitNewLine,
            SplitSpaceNewLine = Internal.SplitSpaceNewLine
        };
    }
}