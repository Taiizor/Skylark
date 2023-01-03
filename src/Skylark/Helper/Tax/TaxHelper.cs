using HD = Skylark.Helper.Detect;

namespace Skylark.Helper
{
    internal class TaxHelper
    {
        public static string GetConvert(string Value)
        {
            return Value.Replace(',', HD.Symbol()).Replace('.', HD.Symbol());
        }

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