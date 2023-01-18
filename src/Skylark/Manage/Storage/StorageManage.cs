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
        public const decimal Value = 10;

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
        public static readonly Dictionary<EST, Dictionary<EST, decimal>> Converter = new()
        {
            {
                EST.Bit, new()
                {
                    { EST.Bit, 1M },
                    { EST.Byte, 0.125M },
                    { EST.Kilobyte, 0.000125M },
                    { EST.Megabyte, 0.000000125M },
                    { EST.Gigabyte, 0.000000000125M },
                    { EST.Terabyte, 0.000000000000125M },
                    { EST.Petabyte, 0.000000000000000125M },
                    { EST.Exabyte, 0.000000000000000000125M },
                    { EST.Zetabyte, 0.000000000000000000000125M },
                    { EST.Yottabyte, 0.000000000000000000000000125M }
                }
            },
            {
                EST.Byte, new()
                {
                    { EST.Bit, 8M },
                    { EST.Byte, 1M },
                    { EST.Kilobyte, 0.001M },
                    { EST.Megabyte, 0.0000010M },
                    { EST.Gigabyte, 0.0000000010M },
                    { EST.Terabyte, 0.0000000000010M },
                    { EST.Petabyte, 0.0000000000000010M },
                    { EST.Exabyte, 0.0000000000000000010M },
                    { EST.Zetabyte, 0.0000000000000000000010M },
                    { EST.Yottabyte, 0.0000000000000000000000010M }
                }
            },
            {
                EST.Kilobyte, new()
                {
                    { EST.Bit, 8000M },
                    { EST.Byte, 1000M },
                    { EST.Kilobyte, 1M },
                    { EST.Megabyte, 0.001M },
                    { EST.Gigabyte, 0.000001M },
                    { EST.Terabyte, 0.000000001M },
                    { EST.Petabyte, 0.000000000001M },
                    { EST.Exabyte, 0.000000000000001M },
                    { EST.Zetabyte, 0.000000000000000001M },
                    { EST.Yottabyte, 0.000000000000000000001M }
                }
            },
            {
                EST.Megabyte, new()
                {
                    { EST.Bit, 8000000M },
                    { EST.Byte, 1000000M },
                    { EST.Kilobyte, 1000M },
                    { EST.Megabyte, 1M },
                    { EST.Gigabyte, 0.001M },
                    { EST.Terabyte, 0.000001M },
                    { EST.Petabyte, 0.000000001M },
                    { EST.Exabyte, 0.000000000001M },
                    { EST.Zetabyte, 0.000000000000001M },
                    { EST.Yottabyte, 0.000000000000000001M }
                }
            },
            {
                EST.Gigabyte, new()
                {
                    { EST.Bit, 8000000000M },
                    { EST.Byte, 1000000000M },
                    { EST.Kilobyte, 1000000M },
                    { EST.Megabyte, 1000M },
                    { EST.Gigabyte, 1M },
                    { EST.Terabyte, 0.001M },
                    { EST.Petabyte, 0.000001M },
                    { EST.Exabyte, 0.000000001M },
                    { EST.Zetabyte, 0.000000000001M },
                    { EST.Yottabyte, 0.000000000000001M }
                }
            },
            {
                EST.Terabyte, new()
                {
                    { EST.Bit, 8000000000000M },
                    { EST.Byte, 1000000000000M },
                    { EST.Kilobyte, 1000000000M },
                    { EST.Megabyte, 1000000M },
                    { EST.Gigabyte, 1000M },
                    { EST.Terabyte, 1M },
                    { EST.Petabyte, 0.001M },
                    { EST.Exabyte, 0.000001M },
                    { EST.Zetabyte, 0.000000001M },
                    { EST.Yottabyte, 0.000000000001M }
                }
            },
            {
                EST.Petabyte, new()
                {
                    { EST.Bit, 8000000000000000M },
                    { EST.Byte, 1000000000000000M },
                    { EST.Kilobyte, 1000000000000M },
                    { EST.Megabyte, 1000000000M },
                    { EST.Gigabyte, 1000000M },
                    { EST.Terabyte, 1000M },
                    { EST.Petabyte, 1M },
                    { EST.Exabyte, 0.001M },
                    { EST.Zetabyte, 0.000001M },
                    { EST.Yottabyte, 0.000000001M }
                }
            },
            {
                EST.Exabyte, new()
                {
                    { EST.Bit, 8000000000000000000M },
                    { EST.Byte, 1000000000000000000M },
                    { EST.Kilobyte, 1000000000000000M },
                    { EST.Megabyte, 1000000000000M },
                    { EST.Gigabyte, 1000000000M },
                    { EST.Terabyte, 1000000M },
                    { EST.Petabyte, 1000M },
                    { EST.Exabyte, 1M },
                    { EST.Zetabyte, 0.001M },
                    { EST.Yottabyte, 0.000001M }
                }
            },
            {
                EST.Zetabyte, new()
                {
                    { EST.Bit, 8000000000000000000000M },
                    { EST.Byte, 1000000000000000000000M },
                    { EST.Kilobyte, 1000000000000000000M },
                    { EST.Megabyte, 1000000000000000M },
                    { EST.Gigabyte, 1000000000000M },
                    { EST.Terabyte, 1000000000M },
                    { EST.Petabyte, 1000000M },
                    { EST.Exabyte, 1000M },
                    { EST.Zetabyte, 1M },
                    { EST.Yottabyte, 0.001M }
                }
            },
            {
                EST.Yottabyte, new()
                {
                    { EST.Bit, 8000000000000000000000000M },
                    { EST.Byte, 1000000000000000000000000M },
                    { EST.Kilobyte, 1000000000000000000000M },
                    { EST.Megabyte, 1000000000000000000M },
                    { EST.Gigabyte, 1000000000000000M },
                    { EST.Terabyte, 1000000000000M },
                    { EST.Petabyte, 1000000000M },
                    { EST.Exabyte, 1000000M },
                    { EST.Zetabyte, 1000M },
                    { EST.Yottabyte, 1M }
                }
            }
        };
    }
}