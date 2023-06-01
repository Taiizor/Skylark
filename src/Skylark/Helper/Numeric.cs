using E = Skylark.Exception;
using ECNT = Skylark.Enum.ClearNumericType;
using HC = Skylark.Helper.Converter;
using HD = Skylark.Helper.Detect;
using HL = Skylark.Helper.Length;

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
        internal const ECNT ClearType = ECNT.Dot;

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
        public static async Task<double> ToDoubleAsync(string Value)
        {
            return await Task.Run(() => ToDouble(Value));
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
        public static async Task<double> ToDoubleAsync(decimal Value)
        {
            return await Task.Run(() => ToDouble(Value));
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
        public static async Task<decimal> ToDecimalAsync(string Value)
        {
            return await Task.Run(() => ToDecimal(Value));
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
        public static async Task<decimal> ToDecimalAsync(double Value)
        {
            return await Task.Run(() => ToDecimal(Value));
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
                return Numeral(Result, Decimal, Fraction, Digit, Number, HC.Convert(Clear, ClearType));
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
        public static async Task<string> NumeralAsync(object Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', string Clear = DefaultType)
        {
            return await Task.Run(() => Numeral(Value, Decimal, Fraction, Digit, Number, Clear));
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
        public static string Numeral(object Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', ECNT Clear = ClearType)
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
        public static async Task<string> NumeralAsync(object Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', ECNT Clear = ClearType)
        {
            return await Task.Run(() => Numeral(Value, Decimal, Fraction, Digit, Number, Clear));
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
        private static string Numeral(string Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0', ECNT Clear = ClearType)
        {
            Digit = HL.Clamp(Digit, 0, 99);

            string Temp = HL.Parameter($"{Value}", "123456");

            Temp = Clear switch
            {
                ECNT.Dot => Temp.Replace(".", ""),
                ECNT.None => Temp,
                ECNT.Comma => Temp.Replace(",", ""),
                ECNT.Decimal => Temp.Replace(HD.StringCross, ""),
                ECNT.Fraction => Temp.Replace(HD.String, ""),
                ECNT.DotComma => Temp.Replace(".", "").Replace(",", ""),
                ECNT.DecimalFraction => Temp.Replace(HD.String, "").Replace(HD.StringCross, ""),
                _ => throw new E(Error)
            };

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