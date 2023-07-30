using SETT = Skylark.Enum.TaxType;

namespace Skylark.Standard.Manage.Tax
{
    /// <summary>
    /// 
    /// </summary>
    internal static class TaxManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const bool Decimal = true;

        /// <summary>
        /// 
        /// </summary>
        public const string Value = "100.00";

        /// <summary>
        /// 
        /// </summary>
        public const string Total = "125.00";

        /// <summary>
        /// 
        /// </summary>
        public const string Percent = "25.00";

        /// <summary>
        /// 
        /// </summary>
        public const SETT TaxType = SETT.Amount;

        /// <summary>
        /// 
        /// </summary>
        public const string DefaultType = "Amount";
    }
}