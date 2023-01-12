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
        /// <param name="Args"></param>
        /// <returns></returns>
        public static string Formatter(string Format, params object[] Args)
        {
            try
            {
                return string.Format(Format, Args);
            }
            catch
            {
                return Format;
            }
        }
    }
}