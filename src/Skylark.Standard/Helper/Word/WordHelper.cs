using System.Text;
using ME = Skylark.Standard.Manage.External;
using MI = Skylark.Manage.Internal;
using MWWM = Skylark.Standard.Manage.Word.WordManage;
using SWWCS = Skylark.Struct.Word.WordCombineStruct;

namespace Skylark.Standard.Helper.Word
{
    /// <summary>
    /// 
    /// </summary>
    internal static class WordHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public static string[] GetSplit(string List)
        {
            return (List.Length > MI.TextLength ? MWWM.List : List).Split(MI.SplitSpace, ME.SplitOption);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public static string[] GetSplits(string List)
        {
            return (List.Length > MI.TextLength ? MWWM.List : List).Split(MI.SplitSpaceNewLine, ME.SplitOption);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Space"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static SWWCS GetCombine(string[] List, char Space, char Separator)
        {
            int Count = 0;
            StringBuilder Builder = new();

            IEnumerable<IEnumerable<string>> Permutations = GetPermute(List);

            foreach (IEnumerable<string> Permutation in Permutations)
            {
                Count++;
                Builder.Append($"{Separator}{string.Join($"{Space}", Permutation)}");
            }

            return new()
            {
                Result = Builder.ToString().Substring(1),
                Count = Count
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Sequence"></param>
        /// <returns></returns>
        private static IEnumerable<IEnumerable<T>> GetPermute<T>(IEnumerable<T> Sequence)
        {
            if (Sequence == null)
            {
                yield break;
            }

            List<T> List = Sequence.ToList();

            if (List.Any())
            {
                for (int Count = 0; Count < List.Count; Count++)
                {
                    T Item = List[Count];
                    IEnumerable<T> RemainingItems = List.Take(Count).Concat(List.Skip(Count + 1));

                    foreach (IEnumerable<T> PermutationOfRemainder in GetPermute(RemainingItems))
                    {
                        yield return new[] { Item }.Concat(PermutationOfRemainder);
                    }
                }
            }
            else
            {
                yield return Enumerable.Empty<T>();
            }
        }
    }
}