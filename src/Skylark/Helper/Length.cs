﻿using MI = Skylark.Manage.Internal;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Length
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Text(string Value, string Back)
        {
            return Value.Length > MI.TextLength ? Back : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Char"></param>
        /// <param name="MinLength"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static string Text(string Value, char Char, int MinLength, int MaxLength)
        {
            return Value.Length < MinLength ? Value.PadRight(MinLength, Char) : Value.Length > MaxLength ? Value.Substring(0, MaxLength) : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <param name="MinLength"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static string Text(string Value, string Back, int MinLength, int MaxLength)
        {
            return Value.Length < MinLength ? Back : Value.Length > MaxLength ? Back : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Parameter(string Value, string Back)
        {
            return Value.Length > MI.ParameterLength ? Back : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="MinValue"></param>
        /// <param name="MaxValue"></param>
        /// <returns></returns>
        public static int Number(int Value, int MinValue, int MaxValue)
        {
            return Math.Min(MaxValue, Math.Max(Value, MinValue));
        }
    }
}