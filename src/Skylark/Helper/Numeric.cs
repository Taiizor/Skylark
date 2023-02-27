using SE = Skylark.Exception;
using SECNT = Skylark.Enum.ClearNumericType;
using SHC = Skylark.Helper.Converter;
using SHD = Skylark.Helper.Detect;
using SHL = Skylark.Helper.Length;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Numeric
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultType = "Dot";

        /// <summary>
        /// 
        /// </summary>
        internal const SECNT ClearType = SECNT.Dot;

        /// <summary>
        /// 
        /// </summary>
        private const string Error = "Clear variable not selected.";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static double ToDouble(string Value)
        {
            return Convert.ToDouble(Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static Task<double> ToDoubleAsync(string Value)
        {
            return Task.Run(() => ToDouble(Value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static double ToDouble(decimal Value)
        {
            return Convert.ToDouble(Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static Task<double> ToDoubleAsync(decimal Value)
        {
            return Task.Run(() => ToDouble(Value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static decimal ToDecimal(string Value)
        {
            return ToDecimal(double.Parse(Value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static Task<decimal> ToDecimalAsync(string Value)
        {
            return Task.Run(() => ToDecimal(Value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static decimal ToDecimal(double Value)
        {
            return Convert.ToDecimal(Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static Task<decimal> ToDecimalAsync(double Value)
        {
            return Task.Run(() => ToDecimal(Value));
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
        public static string Numeral(object Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', string Clear = DefaultType)
        {
            string Symbol = "EB+-";
            string Result = $"{Value}";

            if (Result.Intersect(Symbol).Any())
            {
                return Result;
            }
            else
            {
                return Numeral(Result, Decimal, Fraction, Digit, Number, SHC.Convert(Clear, ClearType));
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
        public static Task<string> NumeralAsync(object Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', string Clear = DefaultType)
        {
            return Task.Run(() => Numeral(Value, Decimal, Fraction, Digit, Number, Clear));
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
        public static string Numeral(object Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', SECNT Clear = ClearType)
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
        public static Task<string> NumeralAsync(object Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', SECNT Clear = ClearType)
        {
            return Task.Run(() => Numeral(Value, Decimal, Fraction, Digit, Number, Clear));
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
        private static string Numeral(string Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', SECNT Clear = ClearType)
        {
            Digit = SHL.Clamp(Digit, 0, 99);

            string Temp = SHL.Parameter($"{Value}", "123456");

            Temp = Clear switch
            {
                SECNT.Dot => Temp.Replace(".", ""),
                SECNT.None => Temp,
                SECNT.Comma => Temp.Replace(",", ""),
                SECNT.Decimal => Temp.Replace(SHD.StringCross, ""),
                SECNT.Fraction => Temp.Replace(SHD.String, ""),
                SECNT.DotComma => Temp.Replace(".", "").Replace(",", ""),
                SECNT.DecimalFraction => Temp.Replace(SHD.String, "").Replace(SHD.StringCross, ""),
                _ => throw new SE(Error)
            };

            string Last = Temp.Contains(SHD.Char) ? Temp.Substring(Temp.IndexOf(SHD.Char)) : Temp;
            string First = Temp.Contains(SHD.Char) ? Temp.Substring(0, Temp.IndexOf(SHD.Char)) : Temp;

            if (Decimal)
            {
                Temp = string.Empty;

                for (int Count = 0; Count < First.Length; Count++)
                {
                    if (First.Substring(Count, First.Length - Count - 1).Length % 3 == 0)
                    {
                        Temp += $"{First.Substring(Count, 1)}{SHD.CharCross}";
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
                if (Last.Contains(SHD.Char))
                {
                    Last = Last.Substring(Last.IndexOf(SHD.Char), Last.Length - Last.IndexOf(SHD.Char));
                }
                else
                {
                    Last = $"{SHD.Char}{new string(Number, Digit)}";
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