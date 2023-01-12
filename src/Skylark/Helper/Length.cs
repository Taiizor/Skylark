using MI = Skylark.Manage.Internal;

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
        public static string Text(string Value, string Back) => Value.Length > MI.TextLength ? Back : Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Parameter(string Value, string Back) => Value.Length > MI.ParameterLength ? Back : Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="MinValue"></param>
        /// <param name="MaxValue"></param>
        /// <returns></returns>
        public static int Number(int Value, int MinValue, int MaxValue) => Math.Min(MaxValue, Math.Max(Value, MinValue));
    }
}