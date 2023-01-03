using SWCS = Skylark.Struct.WordCombineStruct;
using SWDS = Skylark.Struct.WordDataStruct;

namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    internal class WordManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const string List = "Taiizor Skylark";

        /// <summary>
        /// 
        /// </summary>
        public static readonly SWDS ResultCount = new()
        {
            Word = 0,
            Char = 0
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly SWCS ResultCombine = new()
        {
            Result = string.Empty,
            Count = 0
        };
    }
}