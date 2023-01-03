using SWCS = Skylark.Struct.WordCombineStruct;
using SWDS = Skylark.Struct.WordDataStruct;

namespace Skylark.Manage
{
    internal class WordManage
    {
        public const string List = "Taiizor Skylark";

        public static readonly SWDS ResultCount = new()
        {
            Word = 0,
            Char = 0
        };

        public static readonly SWCS ResultCombine = new()
        {
            Result = string.Empty,
            Count = 0
        };
    }
}