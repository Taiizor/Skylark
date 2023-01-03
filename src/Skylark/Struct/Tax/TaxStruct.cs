using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TaxCalcStruct
    {
        public string Price;
        public string VatPrice;
        public string TotalPrice;
    }
}