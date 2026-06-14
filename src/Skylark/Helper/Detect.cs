using System.Globalization;
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
        public static char Char => Separator(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator, '.');

        /// <summary>
        ///
        /// </summary>
        public static char CharCross => Separator(CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator, Char == '.' ? ',' : '.');

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
        /// Returns the first character of the culture separator, falling back when it is empty or non-single-char (e.g. Arabic '٫' U+066B, U+066C).
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        private static char Separator(string Value, char Back)
        {
            return string.IsNullOrEmpty(Value) ? Back : Value[0];
        }
    }
}