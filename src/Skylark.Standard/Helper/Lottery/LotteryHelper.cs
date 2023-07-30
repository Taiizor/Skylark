using SMI = Skylark.Manage.Internal;
using SSME = Skylark.Standard.Manage.External;
using SSMLLM = Skylark.Standard.Manage.Lottery.LotteryManage;

namespace Skylark.Standard.Helper.Lottery
{
    /// <summary>
    /// 
    /// </summary>
    internal static class LotteryHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static string[] GetSplit(string List, bool Repeated)
        {
            List = List.Length > SMI.TextLength ? SSMLLM.List : List;

            string[] Result = List.Split(SMI.SplitNewLine, SSME.SplitOption);

            return Repeated ? Result : Result.Distinct().ToArray();
        }
    }
}