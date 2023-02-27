using SEDT = Skylark.Enum.DetectType;

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
        public static SEDT Enum => Char switch
        {
            '.' => SEDT.Dot,
            ',' => SEDT.Comma,
            _ => SEDT.None,
        };

        /// <summary>
        /// 
        /// </summary>
        public static SEDT EnumCross => CharCross switch
        {
            '.' => SEDT.Dot,
            ',' => SEDT.Comma,
            _ => SEDT.None,
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