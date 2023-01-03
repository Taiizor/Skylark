using SLDS = Skylark.Struct.LotteryDrawStruct;

namespace Skylark.Manage
{
    internal class LotteryManage
    {
        public const bool Repeat = false;

        public const int WinnerCount = 1;

        public const int ReserveCount = 0;

        public static readonly SLDS Result = new()
        {
            Winners = new() { "Taiizor" },
            Reserve = new() { "Skylark" }
        };

        public const string List = "Taiizor\nSkylark";

        public const string Error = "Taiizor Skylark";
    }
}