namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Format
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Case"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        public static string Formatter(object Format, bool Case, bool Invariant = true)
        {
            return Formatter($"{Format}", Case, Invariant);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Case"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        public static async Task<string> FormatterAsync(object Format, bool Case, bool Invariant = true)
        {
            return await Task.Run(() => Formatter(Format, Case, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Case"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        public static string Formatter(string Format, bool Case, bool Invariant = true)
        {
            if (Invariant)
            {
                return Case == false ? Format.ToLowerInvariant() : Format.ToUpperInvariant();
            }
            else
            {
                return Case == false ? Format.ToLower() : Format.ToUpper();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Case"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        public static async Task<string> FormatterAsync(string Format, bool Case, bool Invariant = true)
        {
            return await Task.Run(() => Formatter(Format, Case, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        public static string Formatter(object Format, params object[] Args)
        {
            return Formatter($"{Format}", Args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        public static async Task<string> FormatterAsync(object Format, params object[] Args)
        {
            return await Task.Run(() => Formatter(Format, Args));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        public static string Formatter(string Format, params object[] Args)
        {
            return string.Format(Format, Args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        public static async Task<string> FormatterAsync(string Format, params object[] Args)
        {
            return await Task.Run(() => Formatter(Format, Args));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Provider"></param>
        /// <param name="Format"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        public static string Formatter(IFormatProvider Provider, string Format, params object[] Args)
        {
            return string.Format(Provider, Format, Args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Provider"></param>
        /// <param name="Format"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        public static async Task<string> FormatterAsync(IFormatProvider Provider, string Format, params object[] Args)
        {
            return await Task.Run(() => Formatter(Provider, Format, Args));
        }
    }
}