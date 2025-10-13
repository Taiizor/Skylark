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
            // Determine base: Toucan = 1000 (decimal), Palila = 1024 (binary)
            int BaseValue = Mode == SEMST.Toucan ? 1000 : 1024;

            // Get enum positions (Bit=0, Byte=1, Kilobyte=2, etc.)
            int InputIndex = (int)Input;
            int OutputIndex = (int)Output;

            // Calculate conversion factor
            double ConversionFactor;

            // Special handling for Bit (always 8 bits = 1 byte)
            if (Input == SEST.Bit && Output == SEST.Bit)
            {
                ConversionFactor = 1d;
            }
            else if (Input == SEST.Bit && Output == SEST.Byte)
            {
                ConversionFactor = 0.125d; // 1 bit = 1/8 byte
            }
            else if (Input == SEST.Bit && Output > SEST.Byte)
            {
                // Bit to larger units: first convert to Byte, then apply power
                double ToByte = 0.125d;
                int PowerDiff = OutputIndex - 1; // Byte is at index 1
                ConversionFactor = ToByte / Math.Pow(BaseValue, PowerDiff);
            }
            else if (Input == SEST.Byte && Output == SEST.Bit)
            {
                ConversionFactor = 8d; // 1 byte = 8 bits
            }
            else if (Input > SEST.Byte && Output == SEST.Bit)
            {
                // Larger units to Bit: first convert to Byte, then multiply by 8
                int PowerDiff = InputIndex - 1; // Byte is at index 1
                ConversionFactor = Math.Pow(BaseValue, PowerDiff) * 8d;
            }
            else if (Input == SEST.Byte || Output == SEST.Byte)
            {
                // One unit is Byte, the other is larger
                if (Input == SEST.Byte)
                {
                    // Byte to larger: divide
                    int PowerDiff = OutputIndex - 1;
                    ConversionFactor = 1d / Math.Pow(BaseValue, PowerDiff);
                }
                else
                {
                    // Larger to Byte: multiply
                    int PowerDiff = InputIndex - 1;
                    ConversionFactor = Math.Pow(BaseValue, PowerDiff);
                }
            }
            else
            {
                // Both are Byte or larger (Kilobyte, Megabyte, etc.)
                if (Input == Output)
                {
                    ConversionFactor = 1d;
                }
                else
                {
                    int PowerDiff = InputIndex - OutputIndex;

                    if (PowerDiff > 0)
                    {
                        // Input is larger: multiply
                        ConversionFactor = Math.Pow(BaseValue, PowerDiff);
                    }
                    else
                    {
                        // Output is larger: divide
                        ConversionFactor = 1d / Math.Pow(BaseValue, Math.Abs(PowerDiff));
                    }
                }
            }

            return Value * ConversionFactor;
        }
    }
}