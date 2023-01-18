using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct TaxCalcStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public string Price;
        /// <summary>
        /// 
        /// </summary>
        public string VatPrice;
        /// <summary>
        /// 
        /// </summary>
        public string TotalPrice;
    }
}