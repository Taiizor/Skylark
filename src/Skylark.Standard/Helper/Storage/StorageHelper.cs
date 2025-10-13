using SEMST = Skylark.Enum.ModeStorageType;
using SEST = Skylark.Enum.StorageType;

namespace Skylark.Standard.Helper.Storage
{
    /// <summary>
    /// 
    /// </summary>
    internal static class StorageHelper
    {
        /// <summary>
        /// Converts storage value from Input type to Output type based on mode (Palila/Toucan)
        /// </summary>
        /// <param name="Value">Value to convert</param>
        /// <param name="Input">Input type</param>
        /// <param name="Output">Output type</param>
        /// <param name="Mode">Mode type</param>
        /// <returns>Converted value</returns>
        public static double Convert(double Value, SEST Input, SEST Output, SEMST Mode)
        {
            double BaseValue = Mode == SEMST.Toucan ? 1000d : 1024d;

            if (Input == SEST.Bit && Output == SEST.Bit)
            {
                return Value;
            }

            if (Input == SEST.Bit && Output == SEST.Byte)
            {
                return Value / 8d;
            }

            if (Input == SEST.Byte && Output == SEST.Bit)
            {
                return Value * 8d;
            }

            if (Input == SEST.Bit)
            {
                int PowerDiff = (int)Output - 1;
                return Value / (8d * Math.Pow(BaseValue, PowerDiff));
            }

            if (Output == SEST.Bit)
            {
                int PowerDiff = (int)Input - 1;
                return Value * 8d * Math.Pow(BaseValue, PowerDiff);
            }

            int Diff = (int)Input - (int)Output;
            return Value * Math.Pow(BaseValue, Diff);
        }
    }
}