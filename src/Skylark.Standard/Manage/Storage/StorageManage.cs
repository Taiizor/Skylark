using SEMST = Skylark.Enum.ModeStorageType;
using SEST = Skylark.Enum.StorageType;
using SSSSS = Skylark.Struct.Storage.StorageStruct;

namespace Skylark.Standard.Manage.Storage
{
    /// <summary>
    /// 
    /// </summary>
    internal static class StorageManage
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
        public const SEST InputType = SEST.Bit;
        /// <summary>
        /// 
        /// </summary>
        public const SEST OutputType = SEST.Byte;

        /// <summary>
        /// 
        /// </summary>
        public const SEMST ModeType = SEMST.Toucan;

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
        public static readonly SSSSS Result = new()
        {
            Value = Value,
            Type = InputType,
            Text = DefaultInput
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<SEMST, Dictionary<SEST, Dictionary<SEST, double>>> Converter = new()
        {
            {
                SEMST.Toucan, new()
                {
                    {
                        SEST.Bit, new()
                        {
                            { SEST.Bit, 1d },
                            { SEST.Byte, 0.125d },
                            { SEST.Kilobyte, 0.000125d },
                            { SEST.Megabyte, 0.000000125d },
                            { SEST.Gigabyte, 0.000000000125d },
                            { SEST.Terabyte, 0.000000000000125d },
                            { SEST.Petabyte, 0.000000000000000125d },
                            { SEST.Exabyte, 0.000000000000000000125d },
                            { SEST.Zetabyte, 0.000000000000000000000125d },
                            { SEST.Yottabyte, 0.000000000000000000000000125d }
                        }
                    },
                    {
                        SEST.Byte, new()
                        {
                            { SEST.Bit, 8d },
                            { SEST.Byte, 1d },
                            { SEST.Kilobyte, 0.001d },
                            { SEST.Megabyte, 0.000001d },
                            { SEST.Gigabyte, 0.000000001d },
                            { SEST.Terabyte, 0.000000000001d },
                            { SEST.Petabyte, 0.000000000000001d },
                            { SEST.Exabyte, 0.000000000000000001d },
                            { SEST.Zetabyte, 0.000000000000000000001d },
                            { SEST.Yottabyte, 0.000000000000000000000001d }
                        }
                    },
                    {
                        SEST.Kilobyte, new()
                        {
                            { SEST.Bit, 8000d },
                            { SEST.Byte, 1000d },
                            { SEST.Kilobyte, 1d },
                            { SEST.Megabyte, 0.001d },
                            { SEST.Gigabyte, 0.000001d },
                            { SEST.Terabyte, 0.000000001d },
                            { SEST.Petabyte, 0.000000000001d },
                            { SEST.Exabyte, 0.000000000000001d },
                            { SEST.Zetabyte, 0.000000000000000001d },
                            { SEST.Yottabyte, 0.000000000000000000001d }
                        }
                    },
                    {
                        SEST.Megabyte, new()
                        {
                            { SEST.Bit, 8000000d },
                            { SEST.Byte, 1000000d },
                            { SEST.Kilobyte, 1000d },
                            { SEST.Megabyte, 1d },
                            { SEST.Gigabyte, 0.001d },
                            { SEST.Terabyte, 0.000001d },
                            { SEST.Petabyte, 0.000000001d },
                            { SEST.Exabyte, 0.000000000001d },
                            { SEST.Zetabyte, 0.000000000000001d },
                            { SEST.Yottabyte, 0.000000000000000001d }
                        }
                    },
                    {
                        SEST.Gigabyte, new()
                        {
                            { SEST.Bit, 8000000000d },
                            { SEST.Byte, 1000000000d },
                            { SEST.Kilobyte, 1000000d },
                            { SEST.Megabyte, 1000d },
                            { SEST.Gigabyte, 1d },
                            { SEST.Terabyte, 0.001d },
                            { SEST.Petabyte, 0.000001d },
                            { SEST.Exabyte, 0.000000001d },
                            { SEST.Zetabyte, 0.000000000001d },
                            { SEST.Yottabyte, 0.000000000000001d }
                        }
                    },
                    {
                        SEST.Terabyte, new()
                        {
                            { SEST.Bit, 8000000000000d },
                            { SEST.Byte, 1000000000000d },
                            { SEST.Kilobyte, 1000000000d },
                            { SEST.Megabyte, 1000000d },
                            { SEST.Gigabyte, 1000d },
                            { SEST.Terabyte, 1d },
                            { SEST.Petabyte, 0.001d },
                            { SEST.Exabyte, 0.000001d },
                            { SEST.Zetabyte, 0.000000001d },
                            { SEST.Yottabyte, 0.000000000001d }
                        }
                    },
                    {
                        SEST.Petabyte, new()
                        {
                            { SEST.Bit, 8000000000000000d },
                            { SEST.Byte, 1000000000000000d },
                            { SEST.Kilobyte, 1000000000000d },
                            { SEST.Megabyte, 1000000000d },
                            { SEST.Gigabyte, 1000000d },
                            { SEST.Terabyte, 1000d },
                            { SEST.Petabyte, 1d },
                            { SEST.Exabyte, 0.001d },
                            { SEST.Zetabyte, 0.000001d },
                            { SEST.Yottabyte, 0.000000001d }
                        }
                    },
                    {
                        SEST.Exabyte, new()
                        {
                            { SEST.Bit, 8000000000000000000d },
                            { SEST.Byte, 1000000000000000000d },
                            { SEST.Kilobyte, 1000000000000000d },
                            { SEST.Megabyte, 1000000000000d },
                            { SEST.Gigabyte, 1000000000d },
                            { SEST.Terabyte, 1000000d },
                            { SEST.Petabyte, 1000d },
                            { SEST.Exabyte, 1d },
                            { SEST.Zetabyte, 0.001d },
                            { SEST.Yottabyte, 0.000001d }
                        }
                    },
                    {
                        SEST.Zetabyte, new()
                        {
                            { SEST.Bit, 8000000000000000000000d },
                            { SEST.Byte, 1000000000000000000000d },
                            { SEST.Kilobyte, 1000000000000000000d },
                            { SEST.Megabyte, 1000000000000000d },
                            { SEST.Gigabyte, 1000000000000d },
                            { SEST.Terabyte, 1000000000d },
                            { SEST.Petabyte, 1000000d },
                            { SEST.Exabyte, 1000d },
                            { SEST.Zetabyte, 1d },
                            { SEST.Yottabyte, 0.001d }
                        }
                    },
                    {
                        SEST.Yottabyte, new()
                        {
                            { SEST.Bit, 8000000000000000000000000d },
                            { SEST.Byte, 1000000000000000000000000d },
                            { SEST.Kilobyte, 1000000000000000000000d },
                            { SEST.Megabyte, 1000000000000000000d },
                            { SEST.Gigabyte, 1000000000000000d },
                            { SEST.Terabyte, 1000000000000d },
                            { SEST.Petabyte, 1000000000d },
                            { SEST.Exabyte, 1000000d },
                            { SEST.Zetabyte, 1000d },
                            { SEST.Yottabyte, 1d }
                        }
                    }
                }
            },
            {
                SEMST.Palila, new()
                {
                    {
                        SEST.Bit, new()
                        {
                            { SEST.Bit, 1d },
                            { SEST.Byte, 0.125d },
                            { SEST.Kilobyte, 0.000125d },
                            { SEST.Megabyte, 0.000000125d },
                            { SEST.Gigabyte, 0.000000000125d },
                            { SEST.Terabyte, 0.000000000000125d },
                            { SEST.Petabyte, 0.000000000000000125d },
                            { SEST.Exabyte, 0.000000000000000000125d },
                            { SEST.Zetabyte, 0.000000000000000000000125d },
                            { SEST.Yottabyte, 0.000000000000000000000000125d }
                        }
                    },
                    {
                        SEST.Byte, new()
                        {
                            { SEST.Bit, 8d },
                            { SEST.Byte, 1d },
                            { SEST.Kilobyte, 0.0009765625d },
                            { SEST.Megabyte, 0.0000009765625d },
                            { SEST.Gigabyte, 0.0000000009765625d },
                            { SEST.Terabyte, 0.0000000000009765625d },
                            { SEST.Petabyte, 0.0000000000000009765625d },
                            { SEST.Exabyte, 0.0000000000000000009765625d },
                            { SEST.Zetabyte, 0.0000000000000000000009765625d },
                            { SEST.Yottabyte, 0.0000000000000000000000009765625d }
                        }
                    },
                    {
                        SEST.Kilobyte, new()
                        {
                            { SEST.Bit, 8192d },
                            { SEST.Byte, 1024d },
                            { SEST.Kilobyte, 1d },
                            { SEST.Megabyte, 0.0009765625d },
                            { SEST.Gigabyte, 0.0000009765625d },
                            { SEST.Terabyte, 0.0000000009765625d },
                            { SEST.Petabyte, 0.0000000000009765625d },
                            { SEST.Exabyte, 0.0000000000000009765625d },
                            { SEST.Zetabyte, 0.0000000000000000009765625d },
                            { SEST.Yottabyte, 0.0000000000000000000009765625d }
                        }
                    },
                    {
                        SEST.Megabyte, new()
                        {
                            { SEST.Bit, 8388608d },
                            { SEST.Byte, 1048576d },
                            { SEST.Kilobyte, 1024d },
                            { SEST.Megabyte, 1d },
                            { SEST.Gigabyte, 0.0009765625d },
                            { SEST.Terabyte, 0.0000009765625d },
                            { SEST.Petabyte, 0.0000000009765625d },
                            { SEST.Exabyte, 0.0000000000009765625d },
                            { SEST.Zetabyte, 0.0000000000000009765625d },
                            { SEST.Yottabyte, 0.0000000000000000009765625d }
                        }
                    },
                    {
                        SEST.Gigabyte, new()
                        {
                            { SEST.Bit, 8589934592d },
                            { SEST.Byte, 1073741824d },
                            { SEST.Kilobyte, 1048576d },
                            { SEST.Megabyte, 1024d },
                            { SEST.Gigabyte, 1d },
                            { SEST.Terabyte, 0.0009765625d },
                            { SEST.Petabyte, 0.0000009765625d },
                            { SEST.Exabyte, 0.0000000009765625d },
                            { SEST.Zetabyte, 0.0000000000009765625d },
                            { SEST.Yottabyte, 0.0000000000000009765625d }
                        }
                    },
                    {
                        SEST.Terabyte, new()
                        {
                            { SEST.Bit, 8796093022208d },
                            { SEST.Byte, 1099511627776d },
                            { SEST.Kilobyte, 1073741824d },
                            { SEST.Megabyte, 1048576d },
                            { SEST.Gigabyte, 1024d },
                            { SEST.Terabyte, 1d },
                            { SEST.Petabyte, 0.0009765625d },
                            { SEST.Exabyte, 0.0000009765625d },
                            { SEST.Zetabyte, 0.0000000009765625d },
                            { SEST.Yottabyte, 0.0000000000009765625d }
                        }
                    },
                    {
                        SEST.Petabyte, new()
                        {
                            { SEST.Bit, 9007199254740992d },
                            { SEST.Byte, 1125899906842624d },
                            { SEST.Kilobyte, 1099511627776d },
                            { SEST.Megabyte, 1073741824d },
                            { SEST.Gigabyte, 1048576d },
                            { SEST.Terabyte, 1024d },
                            { SEST.Petabyte, 1d },
                            { SEST.Exabyte, 0.0009765625d },
                            { SEST.Zetabyte, 0.0000009765625d },
                            { SEST.Yottabyte, 0.0000000009765625d }
                        }
                    },
                    {
                        SEST.Exabyte, new()
                        {
                            { SEST.Bit, 9223372036854775808d },
                            { SEST.Byte, 1152921504606846976d },
                            { SEST.Kilobyte, 1125899906842624d },
                            { SEST.Megabyte, 1099511627776d },
                            { SEST.Gigabyte, 1073741824d },
                            { SEST.Terabyte, 1048576d },
                            { SEST.Petabyte, 1024d },
                            { SEST.Exabyte, 1d },
                            { SEST.Zetabyte, 0.0009765625d },
                            { SEST.Yottabyte, 0.0000009765625d }
                        }
                    },
                    {
                        SEST.Zetabyte, new()
                        {
                            { SEST.Bit, 9444732965739290427392d },
                            { SEST.Byte, 1180591620717411303424d },
                            { SEST.Kilobyte, 1152921504606846976d },
                            { SEST.Megabyte, 1125899906842624d },
                            { SEST.Gigabyte, 1099511627776d },
                            { SEST.Terabyte, 1073741824d },
                            { SEST.Petabyte, 1048576d },
                            { SEST.Exabyte, 1024d },
                            { SEST.Zetabyte, 1d },
                            { SEST.Yottabyte, 0.0009765625d }
                        }
                    },
                    {
                        SEST.Yottabyte, new()
                        {
                            { SEST.Bit, 9671406556917033397649408d },
                            { SEST.Byte, 1208925819614629174706176d },
                            { SEST.Kilobyte, 1180591620717411303424d },
                            { SEST.Megabyte, 1152921504606846976d },
                            { SEST.Gigabyte, 1125899906842624d },
                            { SEST.Terabyte, 1099511627776d },
                            { SEST.Petabyte, 1073741824d },
                            { SEST.Exabyte, 1048576d },
                            { SEST.Zetabyte, 1024d },
                            { SEST.Yottabyte, 1d }
                        }
                    }
                }
            }
        };
    }
}