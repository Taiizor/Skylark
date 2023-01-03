using System.Globalization;

namespace Skylark.Helper
{
    public class Currency
    {
        /// <summary>
        /// 
        /// </summary>
        public static string Symbol => NumberFormatInfo.CurrentInfo.CurrencySymbol;

        /// <summary>
        /// 
        /// </summary>
        public static string Name => new RegionInfo(CultureInfo.CurrentCulture.Name).CurrencyEnglishName;

        /// <summary>
        /// 
        /// </summary>
        public static string SymbolName => new RegionInfo(CultureInfo.CurrentCulture.Name).ISOCurrencySymbol;

        /// <summary>
        /// 
        /// </summary>
        public static string NativeName => new RegionInfo(CultureInfo.CurrentCulture.Name).CurrencyNativeName;

        /// <summary>
        /// 
        /// </summary>
        public static string EnglishName => new RegionInfo(CultureInfo.CurrentCulture.Name).CurrencyEnglishName;
    }
}