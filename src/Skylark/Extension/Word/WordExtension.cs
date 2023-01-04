using E = Skylark.Exception;
using HWH = Skylark.Helper.WordHelper;
using MWM = Skylark.Manage.WordManage;
using SWCS = Skylark.Struct.WordCombineStruct;
using SWDS = Skylark.Struct.WordDataStruct;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
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
                    throw new E(MWM.ListEmpty);
                }

                return new()
                {
                    Word = Array.Count(Char => !string.IsNullOrEmpty(Char.Trim())),
                    Char = Array.Sum(Char => Char.Length) + Array.Length - 1
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
        /// <returns></returns>
        public static SWCS Combine(string List = MWM.List)
        {
            try
            {
                string[] Array = HWH.GetSplits(List);

                if (!Array.Any())
                {
                    throw new E(MWM.ListEmpty);
                }

                return HWH.GetCombine(Array);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}