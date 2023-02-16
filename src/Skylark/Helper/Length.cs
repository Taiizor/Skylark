using HS = Skylark.Helper.Skymath;
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
        public static string Text(string Value, string Back)
        {
            return Value.Length > MI.TextLength ? Back : Value;
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
        public static int Clamp(int Value, int MinValue, int MaxValue)
        {
            return HS.Clamp(Value, MinValue, MaxValue);
        }
    }
}