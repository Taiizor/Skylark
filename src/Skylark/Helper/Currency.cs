using System.Globalization;

namespace Skylark.Helper
{
    public class Currency
    {
        public static string Symbol => NumberFormatInfo.CurrentInfo.CurrencySymbol;

        public static string Name => new RegionInfo(CultureInfo.CurrentCulture.Name).CurrencyEnglishName;

        public static string SymbolName => new RegionInfo(CultureInfo.CurrentCulture.Name).ISOCurrencySymbol;

        public static string NativeName => new RegionInfo(CultureInfo.CurrentCulture.Name).CurrencyNativeName;

        public static string EnglishName => new RegionInfo(CultureInfo.CurrentCulture.Name).CurrencyEnglishName;
    }
}