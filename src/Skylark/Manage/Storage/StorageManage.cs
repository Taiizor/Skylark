using EST = Skylark.Enum.StorageType;

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
        public const string Error = "The input type is incorrect.";

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<EST, Dictionary<EST, decimal>> Converter = new()
        {
            {
                EST.Bit, new()
                {
                    { EST.Bit, 1M },
                    { EST.Byte, 8M },
                    { EST.Kilobyte, 8192M },
                    { EST.Megabyte, 8388608M },
                    { EST.Gigabyte, 8589934592M },
                    { EST.Terabyte, 8796093022208M },
                    { EST.Petabyte, 9007199254740992M },
                    { EST.Exabyte, 9223372036854775808M },
                    { EST.Zetabyte, 9444732965739290427392M },
                    { EST.Yottabyte, 9671406556917033397649408M }
                }
            }
        };
    }
}