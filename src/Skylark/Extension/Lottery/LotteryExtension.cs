using HLH = Skylark.Helper.LotteryHelper;
using ME = Skylark.Manage.External;
using MLM = Skylark.Manage.LotteryManage;
using SLDS = Skylark.Struct.LotteryDrawStruct;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class LotteryExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="WinnerCount"></param>
        /// <param name="ReserveCount"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static SLDS Draw(string List = MLM.List, int WinnerCount = MLM.WinnerCount, int ReserveCount = MLM.ReserveCount, bool Repeated = MLM.Repeat)
        {
            try
            {
                string[] Array = HLH.GetSplit(List, Repeated);

                int Total = WinnerCount + ReserveCount;

                if (!Array.Any() || Array.Length < Total)
                {
                    return MLM.Result;
                }

                int Count = 0;
                List<string> Win = new();
                List<string> Res = new();

                while (Count < Total)
                {
                    string Item = Array[ME.Randomise.Next(0, Array.Length)];

                    if (!Win.Contains(Item) && !Res.Contains(Item))
                    {
                        if (Count < WinnerCount)
                        {
                            Win.Add(Item);
                        }
                        else
                        {
                            Res.Add(Item);
                        }

                        Count++;
                    }
                }

                return new()
                {
                    Winners = Win,
                    Reserve = Res
                };
            }
            catch
            {
                return new()
                {
                    Winners = new(),
                    Reserve = new()
                };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static string Suffle(string List = MLM.List, bool Repeated = MLM.Repeat)
        {
            try
            {
                string[] Array = HLH.GetSplit(List, Repeated);

                if (!Array.Any())
                {
                    return MLM.Error;
                }

                return string.Join(Environment.NewLine, Array.OrderBy(_ => ME.Randomise.Next()));
            }
            catch
            {
                return MLM.Error;
            }
        }
    }
}