using E = Skylark.Exception;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class Format
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Invariant"></param>
        /// <param name="Case"></param>
        /// <returns></returns>
        public static string Formatter(object Format, bool Case, bool Invariant = true)
        {
            return Formatter($"{Format}", Case, Invariant);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Invariant"></param>
        /// <param name="Case"></param>
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
        public static string Formatter(string Format, params object[] Args)
        {
            try
            {
                return string.Format(Format, Args);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}