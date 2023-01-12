using HD = Skylark.Helper.Detect;
using HF = Skylark.Helper.Format;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class TaxHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string GetConvert(string Value)
        {
            return Value.Replace(',', HD.Char).Replace('.', HD.Char);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static string GetPlaces(decimal Value, bool Separator)
        {
            if (Separator)
            {
                return HF.Formatter("{0:N2}", Value);
            }
            else
            {
                return HF.Formatter("{0:0.00}", Value);
            }
        }
    }
}