using System.Text;
using ME = Skylark.Manage.External;
using MI = Skylark.Manage.Internal;
using MWM = Skylark.Manage.WordManage;
using SWCS = Skylark.Struct.WordCombineStruct;

namespace Skylark.Helper
{
    internal class WordHelper
    {
        public static string[] GetSplit(string List)
        {
            if (List.Length > MI.TextLength)
            {
                List = MWM.List;
            }

            return List.Split(MI.SplitSpace, ME.SplitOption);
        }

        public static string[] GetSplits(string List)
        {
            if (List.Length > MI.TextLength)
            {
                List = MWM.List;
            }

            return List.Split(MI.SplitSpaceNewLine, ME.SplitOption);
        }

        public static SWCS GetCombine(string[] List)
        {
            int Count = 0;
            StringBuilder Builder = new();

            IEnumerable<IEnumerable<string>> Permutations = GetPermute(List);

            foreach (IEnumerable<string> Permutation in Permutations)
            {
                Count++;
                Builder.Append(string.Join(" ", Permutation));
            }

            return new()
            {
                Result = Builder.ToString(),
                Count = Count
            };
        }

        private static IEnumerable<IEnumerable<T>> GetPermute<T>(IEnumerable<T> Sequence)
        {
            if (Sequence == null)
            {
                yield break;
            }

            List<T> List = Sequence.ToList();

            if (!List.Any())
            {
                yield return Enumerable.Empty<T>();
            }
            else
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
        }
    }
}