using EMST = Skylark.Enum.ModeStorageType;
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
        public const EMST ModeType = EMST.Toucan;

        /// <summary>
        /// 
        /// </summary>
        public const string DefaultMode = "Toucan";

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
        public static readonly Dictionary<EMST, Dictionary<EST, Dictionary<EST, double>>> Converter = new()
        {
            {
                EMST.Toucan, new()
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
                            { EST.Megabyte, 0.000001d },
                            { EST.Gigabyte, 0.000000001d },
                            { EST.Terabyte, 0.000000000001d },
                            { EST.Petabyte, 0.000000000000001d },
                            { EST.Exabyte, 0.000000000000000001d },
                            { EST.Zetabyte, 0.000000000000000000001d },
                            { EST.Yottabyte, 0.000000000000000000000001d }
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
                }
            },
            {
                EMST.Palila, new()
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
                            { EST.Kilobyte, 0.0009765625d },
                            { EST.Megabyte, 0.0000009765625d },
                            { EST.Gigabyte, 0.0000000009765625d },
                            { EST.Terabyte, 0.0000000000009765625d },
                            { EST.Petabyte, 0.0000000000000009765625d },
                            { EST.Exabyte, 0.0000000000000000009765625d },
                            { EST.Zetabyte, 0.0000000000000000000009765625d },
                            { EST.Yottabyte, 0.0000000000000000000000009765625d }
                        }
                    },
                    {
                        EST.Kilobyte, new()
                        {
                            { EST.Bit, 8192d },
                            { EST.Byte, 1024d },
                            { EST.Kilobyte, 1d },
                            { EST.Megabyte, 0.0009765625d },
                            { EST.Gigabyte, 0.0000009765625d },
                            { EST.Terabyte, 0.0000000009765625d },
                            { EST.Petabyte, 0.0000000000009765625d },
                            { EST.Exabyte, 0.0000000000000009765625d },
                            { EST.Zetabyte, 0.0000000000000000009765625d },
                            { EST.Yottabyte, 0.0000000000000000000009765625d }
                        }
                    },
                    {
                        EST.Megabyte, new()
                        {
                            { EST.Bit, 8388608d },
                            { EST.Byte, 1048576d },
                            { EST.Kilobyte, 1024d },
                            { EST.Megabyte, 1d },
                            { EST.Gigabyte, 0.0009765625d },
                            { EST.Terabyte, 0.0000009765625d },
                            { EST.Petabyte, 0.0000000009765625d },
                            { EST.Exabyte, 0.0000000000009765625d },
                            { EST.Zetabyte, 0.0000000000000009765625d },
                            { EST.Yottabyte, 0.0000000000000000009765625d }
                        }
                    },
                    {
                        EST.Gigabyte, new()
                        {
                            { EST.Bit, 8589934592d },
                            { EST.Byte, 1073741824d },
                            { EST.Kilobyte, 1048576d },
                            { EST.Megabyte, 1024d },
                            { EST.Gigabyte, 1d },
                            { EST.Terabyte, 0.0009765625d },
                            { EST.Petabyte, 0.0000009765625d },
                            { EST.Exabyte, 0.0000000009765625d },
                            { EST.Zetabyte, 0.0000000000009765625d },
                            { EST.Yottabyte, 0.0000000000000009765625d }
                        }
                    },
                    {
                        EST.Terabyte, new()
                        {
                            { EST.Bit, 8796093022208d },
                            { EST.Byte, 1099511627776d },
                            { EST.Kilobyte, 1073741824d },
                            { EST.Megabyte, 1048576d },
                            { EST.Gigabyte, 1024d },
                            { EST.Terabyte, 1d },
                            { EST.Petabyte, 0.0009765625d },
                            { EST.Exabyte, 0.0000009765625d },
                            { EST.Zetabyte, 0.0000000009765625d },
                            { EST.Yottabyte, 0.0000000000009765625d }
                        }
                    },
                    {
                        EST.Petabyte, new()
                        {
                            { EST.Bit, 9007199254740992d },
                            { EST.Byte, 1125899906842624d },
                            { EST.Kilobyte, 1099511627776d },
                            { EST.Megabyte, 1073741824d },
                            { EST.Gigabyte, 1048576d },
                            { EST.Terabyte, 1024d },
                            { EST.Petabyte, 1d },
                            { EST.Exabyte, 0.0009765625d },
                            { EST.Zetabyte, 0.0000009765625d },
                            { EST.Yottabyte, 0.0000000009765625d }
                        }
                    },
                    {
                        EST.Exabyte, new()
                        {
                            { EST.Bit, 9223372036854775808d },
                            { EST.Byte, 1152921504606846976d },
                            { EST.Kilobyte, 1125899906842624d },
                            { EST.Megabyte, 1099511627776d },
                            { EST.Gigabyte, 1073741824d },
                            { EST.Terabyte, 1048576d },
                            { EST.Petabyte, 1024d },
                            { EST.Exabyte, 1d },
                            { EST.Zetabyte, 0.0009765625d },
                            { EST.Yottabyte, 0.0000009765625d }
                        }
                    },
                    {
                        EST.Zetabyte, new()
                        {
                            { EST.Bit, 9444732965739290427392d },
                            { EST.Byte, 1180591620717411303424d },
                            { EST.Kilobyte, 1152921504606846976d },
                            { EST.Megabyte, 1125899906842624d },
                            { EST.Gigabyte, 1099511627776d },
                            { EST.Terabyte, 1073741824d },
                            { EST.Petabyte, 1048576d },
                            { EST.Exabyte, 1024d },
                            { EST.Zetabyte, 1d },
                            { EST.Yottabyte, 0.0009765625d }
                        }
                    },
                    {
                        EST.Yottabyte, new()
                        {
                            { EST.Bit, 9671406556917033397649408d },
                            { EST.Byte, 1208925819614629174706176d },
                            { EST.Kilobyte, 1180591620717411303424d },
                            { EST.Megabyte, 1152921504606846976d },
                            { EST.Gigabyte, 1125899906842624d },
                            { EST.Terabyte, 1099511627776d },
                            { EST.Petabyte, 1073741824d },
                            { EST.Exabyte, 1048576d },
                            { EST.Zetabyte, 1024d },
                            { EST.Yottabyte, 1d }
                        }
                    }
                }
            }
        };
    }
}