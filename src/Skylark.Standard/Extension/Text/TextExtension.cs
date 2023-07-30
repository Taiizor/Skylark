using System.Text;
using SE = Skylark.Exception;
using SETT = Skylark.Enum.TextType;
using SHL = Skylark.Helper.Length;
using SSMTTM = Skylark.Standard.Manage.Text.TextManage;

namespace Skylark.Standard.Extension.Text
{
    /// <summary>
    /// 
    /// </summary>
    public static class TextExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Length"></param>
        /// <param name="Symbol"></param>
        /// <param name="Method"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Cut(string Text = SSMTTM.Text, int Length = SSMTTM.Length, string Symbol = SSMTTM.CutSymbol, SETT Method = SSMTTM.CutMethod)
        {
            try
            {
                Text = SHL.Text(Text, SSMTTM.Text);
                Symbol = SHL.Parameter(Symbol, SSMTTM.CutSymbol);
                Length = SHL.Clamp(Length, SSMTTM.MinLength, SSMTTM.MaxLength);

                if (Text.Length <= Length)
                {
                    return Text;
                }
                else
                {
                    int Difference = Text.Length - Length;
                    int LeftPart = (Text.Length - Difference) / 2;

                    return Method switch
                    {
                        SETT.End => Text.Substring(0, Length) + Symbol,
                        SETT.Mid => new string(Text.Where((Char, Number) => Number < LeftPart || Number >= LeftPart + Difference).ToArray()).Insert(LeftPart, Symbol),
                        SETT.Start => Symbol + Text.Substring(Difference),
                        _ => throw new SE(SSMTTM.Error),
                    };
                }
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Length"></param>
        /// <param name="Symbol"></param>
        /// <param name="Method"></param>
        /// <returns></returns>
        public static async Task<string> CutAsync(string Text = SSMTTM.Text, int Length = SSMTTM.Length, string Symbol = SSMTTM.CutSymbol, SETT Method = SSMTTM.CutMethod)
        {
            return await Task.Run(() => Cut(Text, Length, Symbol, Method));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Word"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Text(int Word = SSMTTM.Word)
        {
            try
            {
                return Generate(Word, SSMTTM.Pass);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Word"></param>
        /// <returns></returns>
        public static async Task<string> TextAsync(int Word = SSMTTM.Word)
        {
            return await Task.Run(() => Text(Word));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Symbol"></param>
        /// <param name="Word"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string List(int List = SSMTTM.List, char Symbol = SSMTTM.ListSymbol, int Word = SSMTTM.Word)
        {
            try
            {
                List = SHL.Clamp(List, SSMTTM.MinList, SSMTTM.MaxList);

                StringBuilder Builder = new();

                for (int Count = 0; Count < List; Count++)
                {
                    string Temp = Generate(Word, Word * Count);

                    Builder.AppendLine($"{Symbol} {string.Concat(Temp[0].ToString().ToUpperInvariant(), Temp.Substring(1))}");
                }

                return Builder.ToString();
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
        /// <param name="Symbol"></param>
        /// <param name="Word"></param>
        /// <returns></returns>
        public static async Task<string> ListAsync(int List = SSMTTM.List, char Symbol = SSMTTM.ListSymbol, int Word = SSMTTM.Word)
        {
            return await Task.Run(() => TextExtension.List(List, Symbol, Word));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Reverse(string Text = SSMTTM.Text)
        {
            try
            {
                Text = SHL.Text(Text, SSMTTM.Text);

                return new string(Text.Reverse().ToArray());
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static async Task<string> ReverseAsync(string Text = SSMTTM.Text)
        {
            return await Task.Run(() => Reverse(Text));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Paragraph"></param>
        /// <param name="Word"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Paragraph(int Paragraph = SSMTTM.Paragraph, int Word = SSMTTM.Word)
        {
            try
            {
                Paragraph = SHL.Clamp(Paragraph, SSMTTM.MinParagraph, SSMTTM.MaxParagraph);

                StringBuilder Builder = new();

                for (int Count = 0; Count < Paragraph; Count++)
                {
                    if (Builder.Length > 0)
                    {
                        Builder.AppendLine();
                    }

                    string Temp = Generate(Word, Word * Count);

                    Builder.AppendLine(string.Concat(Temp[0].ToString().ToUpperInvariant(), Temp.Substring(1)));
                }

                return Builder.ToString();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Paragraph"></param>
        /// <param name="Word"></param>
        /// <returns></returns>
        public static async Task<string> ParagraphAsync(int Paragraph = SSMTTM.Paragraph, int Word = SSMTTM.Word)
        {
            return await Task.Run(() => TextExtension.Paragraph(Paragraph, Word));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Word"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        private static string Generate(int Word = SSMTTM.Word, int Pass = SSMTTM.Pass)
        {
            try
            {
                Word = SHL.Clamp(Word, SSMTTM.MinWord, SSMTTM.MaxWord);

                string Result = string.Empty;

                for (int Count = 0; Count < Word; Count++)
                {
                    Result += SSMTTM.Words[(Count + Pass) % SSMTTM.Words.Length] + " ";
                }

                if (Result.EndsWith(", "))
                {
                    return Result.Substring(0, Result.Length - 2) + ".";
                }
                else if (Result.EndsWith(". "))
                {
                    return Result.Substring(0, Result.Length - 1);
                }
                else if (Result.EndsWith(" "))
                {
                    return Result.Substring(0, Result.Length - 1) + ".";
                }
                else
                {
                    return SSMTTM.Unknown;
                }
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }
    }
}