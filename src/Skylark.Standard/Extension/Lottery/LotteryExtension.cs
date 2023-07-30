using SE = Skylark.Exception;
using SSHLLH = Skylark.Standard.Helper.Lottery.LotteryHelper;
using SSME = Skylark.Standard.Manage.External;
using SSMLLM = Skylark.Standard.Manage.Lottery.LotteryManage;
using SSLLDS = Skylark.Struct.Lottery.LotteryDrawStruct;

namespace Skylark.Standard.Extension.Lottery
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
        /// <exception cref="SE"></exception>
        public static SSLLDS Draw(string List = SSMLLM.List, int WinnerCount = SSMLLM.WinnerCount, int ReserveCount = SSMLLM.ReserveCount, bool Repeated = SSMLLM.Repeat)
        {
            try
            {
                string[] Array = SSHLLH.GetSplit(List, Repeated);

                int Total = WinnerCount + ReserveCount;

                if (!Array.Any() || Array.Length < Total)
                {
                    if (Array.Length < Total)
                    {
                        throw new SE(SSMLLM.ListSmall);
                    }
                    else
                    {
                        throw new SE(SSMLLM.ListEmpty);
                    }
                }

                int Count = 0;
                List<string> Win = new();
                List<string> Res = new();

                while (Count < Total)
                {
                    string Item = Array[SSME.Randomise.Next(0, Array.Length)];

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
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        public static async Task<SSLLDS> DrawAsync(string List = SSMLLM.List, int WinnerCount = SSMLLM.WinnerCount, int ReserveCount = SSMLLM.ReserveCount, bool Repeated = SSMLLM.Repeat)
        {
            return await Task.Run(() => Draw(List, WinnerCount, ReserveCount, Repeated));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Suffle(string List = SSMLLM.List, bool Repeated = SSMLLM.Repeat)
        {
            try
            {
                string[] Array = SSHLLH.GetSplit(List, Repeated);

                if (!Array.Any())
                {
                    return SSMLLM.Error;
                }

                return string.Join(Environment.NewLine, Array.OrderBy(_ => SSME.Randomise.Next()));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static async Task<string> SuffleAsync(string List = SSMLLM.List, bool Repeated = SSMLLM.Repeat)
        {
            return await Task.Run(() => Suffle(List, Repeated));
        }
    }
}