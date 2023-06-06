using HS = Skylark.Helper.Skymath;
using MI = Skylark.Manage.Internal;
using ME = Skylark.Manage.External;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Length
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Text(string Value, string Back)
        {
            return Value.Length > ME.Configuration.TextLength ? Back : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Path(string Value, string Back)
        {
            return Value.Length > ME.Configuration.PathLength ? Back : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Parameter(string Value, string Back)
        {
            return Value.Length > ME.Configuration.ParameterLength ? Back : Value;
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