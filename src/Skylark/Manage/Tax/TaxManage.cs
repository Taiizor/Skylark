using ETT = Skylark.Enum.TaxType;

namespace Skylark.Manage.Tax
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
        public const ETT TaxType = ETT.Amount;

        /// <summary>
        /// 
        /// </summary>
        public const string DefaultType = "Amount";
    }
}