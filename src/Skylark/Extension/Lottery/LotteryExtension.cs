using E = Skylark.Exception;
using HLLH = Skylark.Helper.Lottery.LotteryHelper;
using ME = Skylark.Manage.External;
using MLLM = Skylark.Manage.Lottery.LotteryManage;
using SLLDS = Skylark.Struct.Lottery.LotteryDrawStruct;

namespace Skylark.Extension.Lottery
{
    /// <summary>
    /// 
    /// </summary>
    public static class LotteryExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="WinnerCount"></param>
        /// <param name="ReserveCount"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static SLLDS Draw(string List = MLLM.List, int WinnerCount = MLLM.WinnerCount, int ReserveCount = MLLM.ReserveCount, bool Repeated = MLLM.Repeat)
        {
            try
            {
                string[] Array = HLLH.GetSplit(List, Repeated);

                int Total = WinnerCount + ReserveCount;

                if (!Array.Any() || Array.Length < Total)
                {
                    if (Array.Length < Total)
                    {
                        throw new E(MLLM.ListSmall);
                    }
                    else
                    {
                        throw new E(MLLM.ListEmpty);
                    }
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
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="WinnerCount"></param>
        /// <param name="ReserveCount"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static Task<SLLDS> DrawAsync(string List = MLLM.List, int WinnerCount = MLLM.WinnerCount, int ReserveCount = MLLM.ReserveCount, bool Repeated = MLLM.Repeat)
        {
            return Task.Run(() => Draw(List, WinnerCount, ReserveCount, Repeated));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static string Suffle(string List = MLLM.List, bool Repeated = MLLM.Repeat)
        {
            try
            {
                string[] Array = HLLH.GetSplit(List, Repeated);

                if (!Array.Any())
                {
                    return MLLM.Error;
                }

                return string.Join(Environment.NewLine, Array.OrderBy(_ => ME.Randomise.Next()));
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static Task<string> SuffleAsync(string List = MLLM.List, bool Repeated = MLLM.Repeat)
        {
            return Task.Run(() => Suffle(List, Repeated));
        }
    }
}