using HD = Skylark.Helper.Detect;

namespace Skylark.Helper
{
    internal class TaxHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string GetConvert(string Value)
        {
            return Value.Replace(',', HD.Symbol()).Replace('.', HD.Symbol());
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
                return string.Format("{0:N2}", Value);
            }
            else
            {
                return string.Format("{0:0.00}", Value);
            }
        }
    }
}