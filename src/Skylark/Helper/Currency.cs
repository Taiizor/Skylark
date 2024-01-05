using ECT = Skylark.Enum.CurrencyType;
using MI = Skylark.Manage.Internal;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Currency
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Currency"></param>
        /// <returns></returns>
        public static string Symbol(ECT Currency)
        {
            if (MI.CurrencySymbols.TryGetValue(Currency, out string Symbol))
            {
                return Symbol;
            }

            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Currency"></param>
        /// <returns></returns>
        public static async Task<string> SymbolAsync(ECT Currency)
        {
            return await Task.Run(() => Symbol(Currency));
        }
    }
}