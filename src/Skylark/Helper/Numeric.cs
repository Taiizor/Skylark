using HD = Skylark.Helper.Detect;
using HL = Skylark.Helper.Length;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class Numeric
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Decimal"></param>
        /// <param name="Fraction"></param>
        /// <param name="Digit"></param>
        /// <param name="Number"></param>
        /// <param name="Clear"></param>
        /// <returns></returns>
        public static string Numeral(object Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', bool Clear = true)
        {
            string Symbol = "EB+-";
            string Result = $"{Value}";

            if (Result.Intersect(Symbol).Any())
            {
                return Result;
            }
            else
            {
                return Numeral(Result, Decimal, Fraction, Digit, Number, Clear);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Decimal"></param>
        /// <param name="Fraction"></param>
        /// <param name="Digit"></param>
        /// <param name="Number"></param>
        /// <param name="Clear"></param>
        /// <returns></returns>
        private static string Numeral(string Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', bool Clear = true)
        {
            Digit = HL.Number(Digit, 0, 99);

            string Temp = HL.Parameter($"{Value}", "123456");

            if (Clear && Temp.Contains(HD.CharCross))
            {
                Temp = Temp.Replace(HD.StringCross, "");
            }

            string Last = Temp.Contains(HD.Char) ? Temp.Substring(Temp.IndexOf(HD.Char)) : Temp;
            string First = Temp.Contains(HD.Char) ? Temp.Substring(0, Temp.IndexOf(HD.Char)) : Temp;

            if (Decimal)
            {
                Temp = string.Empty;

                for (int Count = 0; Count < First.Length; Count++)
                {
                    if (First.Substring(Count, First.Length - Count - 1).Length % 3 == 0)
                    {
                        Temp += $"{First.Substring(Count, 1)}{HD.CharCross}";
                    }
                    else
                    {
                        Temp += First.Substring(Count, 1);
                    }
                }

                First = Temp.Substring(0, Temp.Length - 1);
            }

            if (Fraction && Digit > 0)
            {
                if (Last.Contains(HD.Char))
                {
                    Last = Last.Substring(Last.IndexOf(HD.Char), Last.Length - Last.IndexOf(HD.Char));
                }
                else
                {
                    Last = $"{HD.Char}{new string(Number, Digit)}";
                }

                if (Last.Length < Digit + 1)
                {
                    Last += new string(Number, Digit + 1 - Last.Length);
                }
                else
                {
                    Last = Last.Substring(0, Digit + 1);
                }
            }
            else
            {
                Last = string.Empty;
            }

            return First + Last;
        }
    }
}