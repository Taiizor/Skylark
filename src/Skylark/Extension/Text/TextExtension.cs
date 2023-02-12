using System.Text;
using E = Skylark.Exception;
using ETT = Skylark.Enum.TextType;
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
        /// <param name="Text"></param>
        /// <param name="Length"></param>
        /// <param name="Symbol"></param>
        /// <param name="Method"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string Cut(string Text = MTM.Text, int Length = MTM.Length, string Symbol = MTM.CutSymbol, ETT Method = MTM.CutMethod)
        {
            try
            {
                Text = HL.Text(Text, MTM.Text);
                Symbol = HL.Parameter(Symbol, MTM.CutSymbol);
                Length = HL.Number(Length, MTM.MinLength, MTM.MaxLength);

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
                        _ => throw new E(MTM.Error),
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
        public static Task<string> CutAsync(string Text = MTM.Text, int Length = MTM.Length, string Symbol = MTM.CutSymbol, ETT Method = MTM.CutMethod)
        {
            return Task.Run(() => Cut(Text, Length, Symbol, Method));
        }

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
        /// <param name="Word"></param>
        /// <returns></returns>
        public static Task<string> TextAsync(int Word = MTM.Word)
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
        public static string List(int List = MTM.List, char Symbol = MTM.ListSymbol, int Word = MTM.Word)
        {
            try
            {
                List = HL.Number(List, MTM.MinList, MTM.MaxList);

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
        public static Task<string> ListAsync(int List = MTM.List, char Symbol = MTM.ListSymbol, int Word = MTM.Word)
        {
            return Task.Run(() => TextExtension.List(List, Symbol, Word));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string Reverse(string Text = MTM.Text)
        {
            try
            {
                Text = HL.Text(Text, MTM.Text);

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
        public static Task<string> ReverseAsync(string Text = MTM.Text)
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
        public static string Paragraph(int Paragraph = MTM.Paragraph, int Word = MTM.Word)
        {
            try
            {
                Paragraph = HL.Number(Paragraph, MTM.MinParagraph, MTM.MaxParagraph);

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
        public static Task<string> ParagraphAsync(int Paragraph = MTM.Paragraph, int Word = MTM.Word)
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