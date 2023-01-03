using SLDS = Skylark.Struct.LotteryDrawStruct;

namespace Skylark.Manage
{
    internal class LotteryManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const bool Repeat = false;

        /// <summary>
        /// 
        /// </summary>
        public const int WinnerCount = 1;

        /// <summary>
        /// 
        /// </summary>
        public const int ReserveCount = 0;

        /// <summary>
        /// 
        /// </summary>
        public static readonly SLDS Result = new()
        {
            Winners = new() { "Taiizor" },
            Reserve = new() { "Skylark" }
        };

        /// <summary>
        /// 
        /// </summary>
        public const string List = "Taiizor\nSkylark";

        /// <summary>
        /// 
        /// </summary>
        public const string Error = "Taiizor Skylark";
    }
}