using System.Text;
using E = Skylark.Exception;
using ETT = Skylark.Enum.TextType;
using HL = Skylark.Helper.Length;
using MTTM = Skylark.Standard.Manage.Text.TextManage;

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
        /// <exception cref="E"></exception>
        public static string Cut(string Text = MTTM.Text, int Length = MTTM.Length, string Symbol = MTTM.CutSymbol, ETT Method = MTTM.CutMethod)
        {
            try
            {
                Text = HL.Text(Text, MTTM.Text);
                Symbol = HL.Parameter(Symbol, MTTM.CutSymbol);
                Length = HL.Clamp(Length, MTTM.MinLength, MTTM.MaxLength);

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
                        ETT.End => Text.Substring(0, Length) + Symbol,
                        ETT.Mid => new string(Text.Where((Char, Number) => Number < LeftPart || Number >= LeftPart + Difference).ToArray()).Insert(LeftPart, Symbol),
                        ETT.Start => Symbol + Text.Substring(Difference),
                        _ => throw new E(MTTM.Error),
                    };
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> CutAsync(string Text = MTTM.Text, int Length = MTTM.Length, string Symbol = MTTM.CutSymbol, ETT Method = MTTM.CutMethod)
        {
            return Task.Run(() => Cut(Text, Length, Symbol, Method));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Word"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string Text(int Word = MTTM.Word)
        {
            try
            {
                return Generate(Word, MTTM.Pass);
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
        /// <returns></returns>
        public static Task<string> TextAsync(int Word = MTTM.Word)
        {
            return Task.Run(() => Text(Word));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Symbol"></param>
        /// <param name="Word"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string List(int List = MTTM.List, char Symbol = MTTM.ListSymbol, int Word = MTTM.Word)
        {
            try
            {
                List = HL.Clamp(List, MTTM.MinList, MTTM.MaxList);

                StringBuilder Builder = new();

                for (int Count = 0; Count < List; Count++)
                {
                    string Temp = Generate(Word, Word * Count);

                    Builder.AppendLine($"{Symbol} {string.Concat(Temp[0].ToString().ToUpperInvariant(), Temp.Substring(1))}");
                }

                return Builder.ToString();
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
        public static Task<string> ListAsync(int List = MTTM.List, char Symbol = MTTM.ListSymbol, int Word = MTTM.Word)
        {
            return Task.Run(() => TextExtension.List(List, Symbol, Word));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string Reverse(string Text = MTTM.Text)
        {
            try
            {
                Text = HL.Text(Text, MTTM.Text);

                return new string(Text.Reverse().ToArray());
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static Task<string> ReverseAsync(string Text = MTTM.Text)
        {
            return Task.Run(() => Reverse(Text));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Paragraph"></param>
        /// <param name="Word"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string Paragraph(int Paragraph = MTTM.Paragraph, int Word = MTTM.Word)
        {
            try
            {
                Paragraph = HL.Clamp(Paragraph, MTTM.MinParagraph, MTTM.MaxParagraph);

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
        public static Task<string> ParagraphAsync(int Paragraph = MTTM.Paragraph, int Word = MTTM.Word)
        {
            return Task.Run(() => TextExtension.Paragraph(Paragraph, Word));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Word"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        private static string Generate(int Word = MTTM.Word, int Pass = MTTM.Pass)
        {
            try
            {
                Word = HL.Clamp(Word, MTTM.MinWord, MTTM.MaxWord);

                string Result = string.Empty;

                for (int Count = 0; Count < Word; Count++)
                {
                    Result += MTTM.Words[(Count + Pass) % MTTM.Words.Length] + " ";
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
                    return MTTM.Unknown;
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}