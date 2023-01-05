using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using MTM = Skylark.Manage.TextManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class TextExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Word"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string Text(int Word = MTM.Word)
        {
            try
            {
                return Generate(Word, MTM.Pass);
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
        /// <param name="Symbol"></param>
        /// <param name="Word"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string List(int List = MTM.List, char Symbol = MTM.ListSymbol, int Word = MTM.Word)
        {
            try
            {
                List = HL.Number(List, MTM.MinList, MTM.MaxList);

                string Result = string.Empty;

                for (int Count = 0; Count < List; Count++)
                {
                    if (!string.IsNullOrEmpty(Result))
                    {
                        Result += $"{Environment.NewLine}";
                    }

                    string Temp = Generate(Word, Word * Count);

                    Result += $"{Symbol} {string.Concat(Temp[0].ToString().ToUpperInvariant(), Temp.Substring(1))}";
                }

                return Result;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Paragraph"></param>
        /// <param name="Word"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string Paragraph(int Paragraph = MTM.Paragraph, int Word = MTM.Word)
        {
            try
            {
                Paragraph = HL.Number(Paragraph, MTM.MinParagraph, MTM.MaxParagraph);

                string Result = string.Empty;

                for (int Count = 0; Count < Paragraph; Count++)
                {
                    if (!string.IsNullOrEmpty(Result))
                    {
                        Result += $"{Environment.NewLine}{Environment.NewLine}";
                    }

                    string Temp = Generate(Word, Word * Count);

                    Result += string.Concat(Temp[0].ToString().ToUpperInvariant(), Temp.Substring(1));
                }

                return Result;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Word"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        private static string Generate(int Word = MTM.Word, int Pass = MTM.Pass)
        {
            try
            {
                Word = HL.Number(Word, MTM.MinWord, MTM.MaxWord);

                string Result = string.Empty;

                for (int Count = 0; Count < Word; Count++)
                {
                    Result += MTM.Words[(Count + Pass) % MTM.Words.Length] + " ";
                }

                if (Result.EndsWith(", "))
                {
#if NETSTANDARD2_1
                    return Result[..^2] + ".";
#else
                    return Result.Substring(0, Result.Length - 2) + ".";
#endif
                }
                else if (Result.EndsWith(". "))
                {
#if NETSTANDARD2_1
                    return Result[..^1];
#else
                    return Result.Substring(0, Result.Length - 1);
#endif
                }
                else if (Result.EndsWith(" "))
                {
#if NETSTANDARD2_1
                    return Result[..^1] + ".";
#else
                    return Result.Substring(0, Result.Length - 1) + ".";
#endif
                }
                else
                {
                    return MTM.Unknown;
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}