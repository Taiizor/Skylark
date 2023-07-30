using SE = Skylark.Exception;
using SSHWWH = Skylark.Standard.Helper.Word.WordHelper;
using SSMWWM = Skylark.Standard.Manage.Word.WordManage;
using SSWWCS = Skylark.Struct.Word.WordCombineStruct;
using SSWWDS = Skylark.Struct.Word.WordDataStruct;

namespace Skylark.Standard.Extension.Word
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
        public static SSWWDS Data(string List = SSMWWM.List)
        {
            try
            {
                string[] Array = SSHWWH.GetSplit(List);

                if (!Array.Any())
                {
                    throw new SE(SSMWWM.ListEmpty);
                }

                return new()
                {
                    Word = Array.Count(Char => !string.IsNullOrEmpty(Char.Trim())),
                    Char = Array.Sum(Char => Char.Length) + Array.Length - 1
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
        /// <returns></returns>
        public static async Task<SSWWDS> DataAsync(string List = SSMWWM.List)
        {
            return await Task.Run(() => Data(List));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Space"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SSWWCS Combine(string List = SSMWWM.List, char Space = SSMWWM.Space, char Separator = SSMWWM.Separator)
        {
            try
            {
                string[] Array = SSHWWH.GetSplits(List);

                if (!Array.Any())
                {
                    throw new SE(SSMWWM.ListEmpty);
                }

                return SSHWWH.GetCombine(Array, Space, Separator);
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
        /// <param name="Space"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static async Task<SSWWCS> CombineAsync(string List = SSMWWM.List, char Space = SSMWWM.Space, char Separator = SSMWWM.Separator)
        {
            return await Task.Run(() => Combine(List, Space, Separator));
        }
    }
}