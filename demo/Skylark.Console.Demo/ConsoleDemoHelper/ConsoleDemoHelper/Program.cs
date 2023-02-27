using Skylark.Enum;
using Skylark.Helper;
using Skylark.Standard.Helper;
using System.Globalization;

namespace ConsoleDemoHelper
{
    internal class Program
    {
        static void Main()
        {
            Culture.All = new CultureInfo("en-GB"); //tr-TR

            Console.WriteLine(Culture.CurrentName);
            Console.WriteLine(Culture.CurrentNativeName);
            Console.WriteLine(Culture.CurrentDisplayName);
            Console.WriteLine(Culture.CurrentEnglishName);
            Console.WriteLine(Culture.CurrentTwoLetterISOLanguageName);
            Console.WriteLine(Culture.CurrentThreeLetterISOLanguageName);
            Console.WriteLine(Culture.CurrentThreeLetterWindowsLanguageName);

            Console.WriteLine();

            Console.WriteLine(Numeric.Numeral(123456789, true, true, 6, '0', "None"));
            Console.WriteLine(Numeric.Numeral("123456789", true, true, 6, '0', ClearNumericType.None));
            Console.WriteLine(Numeric.Numeral(12345.6789M, true, true, 6, '0', "None"));
            Console.WriteLine(Numeric.Numeral(12345.6789d, true, true, 6, '0', ClearNumericType.None));
            Console.WriteLine(Numeric.Numeral(12345.6789f, true, true, 6, '0', "None"));
            Console.WriteLine(Numeric.Numeral("12,345.6789", true, true, 6, '0', "Decimal"));
            Console.WriteLine(Numeric.Numeral("12.345,6789", true, true, 6, '0', ClearNumericType.DecimalFraction));
            Console.WriteLine(Numeric.Numeral("XY.XYZ,XYZQ", true, true, 6, '#', ClearNumericType.DotComma));

            Console.WriteLine(Numeric.ToDouble(0.0000114077M));
            Console.WriteLine(Numeric.ToDouble("0.0000114077"));

            Console.WriteLine(Numeric.ToDecimal(1.14077E-5));
            Console.WriteLine(Numeric.ToDecimal("1.14077E-5"));

            Console.WriteLine();

            Console.WriteLine(Adaptation.Cut("123456", 3));
            Console.WriteLine(Adaptation.Add("123456", '*', 12));
            Console.WriteLine(Adaptation.Adapt("123456", '*', 9, 12));
            Console.WriteLine(Adaptation.Feed("123456", "000000000", 9, 12));

            Console.WriteLine();

            Board.Copy("Taiizor Skylark");
            Console.WriteLine(Board.Paste(true, "Empty!"));

            Console.WriteLine();

            Console.WriteLine(Format.Formatter("Hello {0}!", "Jane Doe"));

            Console.WriteLine();

            Console.WriteLine(Currency.Name);
            Console.WriteLine(Currency.Symbol);
            Console.WriteLine(Currency.SymbolName);
            Console.WriteLine(Currency.NativeName);
            Console.WriteLine(Currency.EnglishName);

            Console.WriteLine();

            int[] Int = Fibonacci.Int(48);
            foreach (int number in Int)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n");

            long[] Long = Fibonacci.Long(94);
            foreach (long number in Long)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n");

            decimal[] Decimal = Fibonacci.Decimal(128);
            foreach (decimal number in Decimal)
            {
                Console.Write($"{number} ");
            }

            Console.ReadKey();
        }
    }
}