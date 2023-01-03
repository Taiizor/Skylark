using ME = Skylark.Manage.External;
using MI = Skylark.Manage.Internal;
using MLM = Skylark.Manage.LotteryManage;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class LotteryHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static string[] GetSplit(string List, bool Repeated)
        {
            if (List.Length > MI.TextLength)
            {
                List = MLM.List;
            }

            string[] Result = List.Split(MI.SplitNewLine, ME.SplitOption);

            if (!Repeated && Result.Any())
            {
                return Result.Distinct().ToArray();
            }

            return Result;
        }
    }
}