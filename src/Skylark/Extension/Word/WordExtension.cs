using HWH = Skylark.Helper.WordHelper;
using MWM = Skylark.Manage.WordManage;
using SWCS = Skylark.Struct.WordCombineStruct;
using SWDS = Skylark.Struct.WordDataStruct;

namespace Skylark.Extension
{
    public class WordExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public static SWDS Data(string List = MWM.List)
        {
            try
            {
                string[] Array = HWH.GetSplit(List);

                if (!Array.Any())
                {
                    return MWM.ResultCount;
                }

                return new()
                {
                    Word = Array.Count(Char => !string.IsNullOrEmpty(Char.Trim())),
                    Char = Array.Sum(Char => Char.Length) + Array.Length - 1
                };
            }
            catch
            {
                return MWM.ResultCount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public static SWCS Combine(string List = MWM.List)
        {
            try
            {
                string[] Array = HWH.GetSplits(List);

                if (!Array.Any())
                {
                    return MWM.ResultCombine;
                }

                return HWH.GetCombine(Array);
            }
            catch
            {
                return MWM.ResultCombine;
            }
        }
    }
}