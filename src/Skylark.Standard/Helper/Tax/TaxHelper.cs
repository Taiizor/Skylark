using HD = Skylark.Helper.Detect;
using HF = Skylark.Helper.Format;

namespace Skylark.Standard.Helper.Tax
{
    /// <summary>
    /// 
    /// </summary>
    internal static class TaxHelper
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
        /// <param name="Decimal"></param>
        /// <returns></returns>
        public static string GetPlaces(decimal Value, bool Decimal)
        {
            if (Decimal)
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