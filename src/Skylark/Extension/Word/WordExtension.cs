using E = Skylark.Exception;
using HWWH = Skylark.Helper.Word.WordHelper;
using MWWM = Skylark.Manage.Word.WordManage;
using SWWCS = Skylark.Struct.Word.WordCombineStruct;
using SWWDS = Skylark.Struct.Word.WordDataStruct;

namespace Skylark.Extension.Word
{
    /// <summary>
    /// 
    /// </summary>
    public static class WordExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public static SWWDS Data(string List = MWWM.List)
        {
            try
            {
                string[] Array = HWWH.GetSplit(List);

                if (!Array.Any())
                {
                    throw new E(MWWM.ListEmpty);
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
        public static Task<SWWDS> DataAsync(string List = MWWM.List)
        {
            return Task.Run(() => Data(List));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Space"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static SWWCS Combine(string List = MWWM.List, char Space = MWWM.Space, char Separator = MWWM.Separator)
        {
            try
            {
                string[] Array = HWWH.GetSplits(List);

                if (!Array.Any())
                {
                    throw new E(MWWM.ListEmpty);
                }

                return HWWH.GetCombine(Array, Space, Separator);
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
        /// <param name="Space"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static Task<SWWCS> CombineAsync(string List = MWWM.List, char Space = MWWM.Space, char Separator = MWWM.Separator)
        {
            return Task.Run(() => Combine(List, Space, Separator));
        }
    }
}