using EDT = Skylark.Enum.DetectType;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Detect
    {
        /// <summary>
        /// 
        /// </summary>
        public static char Char => Formula.Contains('.') ? '.' : ',';

        /// <summary>
        /// 
        /// </summary>
        public static char CharCross => Char == '.' ? ',' : '.';

        /// <summary>
        /// 
        /// </summary>
        public static EDT Enum => Char switch
        {
            '.' => EDT.Dot,
            ',' => EDT.Comma,
            _ => EDT.None,
        };

        /// <summary>
        /// 
        /// </summary>
        public static EDT EnumCross => CharCross switch
        {
            '.' => EDT.Dot,
            ',' => EDT.Comma,
            _ => EDT.None,
        };

        /// <summary>
        /// 
        /// </summary>
        public static string String => $"{Char}";

        /// <summary>
        /// 
        /// </summary>
        public static string StringCross => $"{CharCross}";

        /// <summary>
        /// 
        /// </summary>
        private static string Formula => $"{10 / 3f}";
    }
}