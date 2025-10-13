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
            TypeText = DefaultInput
        };
    }
}