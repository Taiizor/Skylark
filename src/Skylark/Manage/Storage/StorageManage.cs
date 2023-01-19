using EST = Skylark.Enum.StorageType;
using SSS = Skylark.Struct.StorageStruct;

namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    internal class StorageManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const bool Type = true;

        /// <summary>
        /// 
        /// </summary>
        public const double Value = 10;

        /// <summary>
        /// 
        /// </summary>
        public const EST InputType = EST.Bit;
        /// <summary>
        /// 
        /// </summary>
        public const EST OutputType = EST.Byte;

        /// <summary>
        /// 
        /// </summary>
        public const string DefaultInput = "Bit";
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultOutput = "Byte";

        /// <summary>
        /// 
        /// </summary>
        public const string Error = "The input type is incorrect.";

        /// <summary>
        /// 
        /// </summary>
        public static readonly SSS Result = new()
        {
            Value = Value,
            Type = InputType,
            Text = DefaultInput
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<EST, Dictionary<EST, double>> Converter = new()
        {
            {
                EST.Bit, new()
                {
                    { EST.Bit, 1d },
                    { EST.Byte, 0.125d },
                    { EST.Kilobyte, 0.000125d },
                    { EST.Megabyte, 0.000000125d },
                    { EST.Gigabyte, 0.000000000125d },
                    { EST.Terabyte, 0.000000000000125d },
                    { EST.Petabyte, 0.000000000000000125d },
                    { EST.Exabyte, 0.000000000000000000125d },
                    { EST.Zetabyte, 0.000000000000000000000125d },
                    { EST.Yottabyte, 0.000000000000000000000000125d }
                }
            },
            {
                EST.Byte, new()
                {
                    { EST.Bit, 8d },
                    { EST.Byte, 1d },
                    { EST.Kilobyte, 0.001d },
                    { EST.Megabyte, 0.0000010d },
                    { EST.Gigabyte, 0.0000000010d },
                    { EST.Terabyte, 0.0000000000010d },
                    { EST.Petabyte, 0.0000000000000010d },
                    { EST.Exabyte, 0.0000000000000000010d },
                    { EST.Zetabyte, 0.0000000000000000000010d },
                    { EST.Yottabyte, 0.0000000000000000000000010d }
                }
            },
            {
                EST.Kilobyte, new()
                {
                    { EST.Bit, 8000d },
                    { EST.Byte, 1000d },
                    { EST.Kilobyte, 1d },
                    { EST.Megabyte, 0.001d },
                    { EST.Gigabyte, 0.000001d },
                    { EST.Terabyte, 0.000000001d },
                    { EST.Petabyte, 0.000000000001d },
                    { EST.Exabyte, 0.000000000000001d },
                    { EST.Zetabyte, 0.000000000000000001d },
                    { EST.Yottabyte, 0.000000000000000000001d }
                }
            },
            {
                EST.Megabyte, new()
                {
                    { EST.Bit, 8000000d },
                    { EST.Byte, 1000000d },
                    { EST.Kilobyte, 1000d },
                    { EST.Megabyte, 1d },
                    { EST.Gigabyte, 0.001d },
                    { EST.Terabyte, 0.000001d },
                    { EST.Petabyte, 0.000000001d },
                    { EST.Exabyte, 0.000000000001d },
                    { EST.Zetabyte, 0.000000000000001d },
                    { EST.Yottabyte, 0.000000000000000001d }
                }
            },
            {
                EST.Gigabyte, new()
                {
                    { EST.Bit, 8000000000d },
                    { EST.Byte, 1000000000d },
                    { EST.Kilobyte, 1000000d },
                    { EST.Megabyte, 1000d },
                    { EST.Gigabyte, 1d },
                    { EST.Terabyte, 0.001d },
                    { EST.Petabyte, 0.000001d },
                    { EST.Exabyte, 0.000000001d },
                    { EST.Zetabyte, 0.000000000001d },
                    { EST.Yottabyte, 0.000000000000001d }
                }
            },
            {
                EST.Terabyte, new()
                {
                    { EST.Bit, 8000000000000d },
                    { EST.Byte, 1000000000000d },
                    { EST.Kilobyte, 1000000000d },
                    { EST.Megabyte, 1000000d },
                    { EST.Gigabyte, 1000d },
                    { EST.Terabyte, 1d },
                    { EST.Petabyte, 0.001d },
                    { EST.Exabyte, 0.000001d },
                    { EST.Zetabyte, 0.000000001d },
                    { EST.Yottabyte, 0.000000000001d }
                }
            },
            {
                EST.Petabyte, new()
                {
                    { EST.Bit, 8000000000000000d },
                    { EST.Byte, 1000000000000000d },
                    { EST.Kilobyte, 1000000000000d },
                    { EST.Megabyte, 1000000000d },
                    { EST.Gigabyte, 1000000d },
                    { EST.Terabyte, 1000d },
                    { EST.Petabyte, 1d },
                    { EST.Exabyte, 0.001d },
                    { EST.Zetabyte, 0.000001d },
                    { EST.Yottabyte, 0.000000001d }
                }
            },
            {
                EST.Exabyte, new()
                {
                    { EST.Bit, 8000000000000000000d },
                    { EST.Byte, 1000000000000000000d },
                    { EST.Kilobyte, 1000000000000000d },
                    { EST.Megabyte, 1000000000000d },
                    { EST.Gigabyte, 1000000000d },
                    { EST.Terabyte, 1000000d },
                    { EST.Petabyte, 1000d },
                    { EST.Exabyte, 1d },
                    { EST.Zetabyte, 0.001d },
                    { EST.Yottabyte, 0.000001d }
                }
            },
            {
                EST.Zetabyte, new()
                {
                    { EST.Bit, 8000000000000000000000d },
                    { EST.Byte, 1000000000000000000000d },
                    { EST.Kilobyte, 1000000000000000000d },
                    { EST.Megabyte, 1000000000000000d },
                    { EST.Gigabyte, 1000000000000d },
                    { EST.Terabyte, 1000000000d },
                    { EST.Petabyte, 1000000d },
                    { EST.Exabyte, 1000d },
                    { EST.Zetabyte, 1d },
                    { EST.Yottabyte, 0.001d }
                }
            },
            {
                EST.Yottabyte, new()
                {
                    { EST.Bit, 8000000000000000000000000d },
                    { EST.Byte, 1000000000000000000000000d },
                    { EST.Kilobyte, 1000000000000000000000d },
                    { EST.Megabyte, 1000000000000000000d },
                    { EST.Gigabyte, 1000000000000000d },
                    { EST.Terabyte, 1000000000000d },
                    { EST.Petabyte, 1000000000d },
                    { EST.Exabyte, 1000000d },
                    { EST.Zetabyte, 1000d },
                    { EST.Yottabyte, 1d }
                }
            }
        };
    }
}