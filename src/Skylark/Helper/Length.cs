using HS = Skylark.Helper.Skymath;
using MI = Skylark.Manage.Internal;

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
            return Value.Length > MI.TextLength ? Back : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static async Task<string> TextAsync(string Value, string Back)
        {
            return await Task.Run(() => Text(Value, Back));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Path(string Value, string Back)
        {
            return Value.Length > MI.PathLength ? Back : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static async Task<string> PathAsync(string Value, string Back)
        {
            return await Task.Run(() => Path(Value, Back));
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
        /// <param name="Back"></param>
        /// <returns></returns>
        public static async Task<string> ParameterAsync(string Value, string Back)
        {
            return await Task.Run(() => Parameter(Value, Back));
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="MinValue"></param>
        /// <param name="MaxValue"></param>
        /// <returns></returns>
        public static async Task<int> ClampAsync(int Value, int MinValue, int MaxValue)
        {
            return await Task.Run(() => Clamp(Value, MinValue, MaxValue));
        }
    }
}