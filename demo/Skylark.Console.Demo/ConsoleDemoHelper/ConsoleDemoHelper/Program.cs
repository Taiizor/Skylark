using Skylark.Enum;
using Skylark.Helper;
using Skylark.Standard.Helper;
using System.Globalization;
using System.Text;
using Currency1 = Skylark.Helper.Currency;
using Currency2 = Skylark.Standard.Helper.Currency;
using TimeZone = Skylark.Helper.TimeZone;

namespace ConsoleDemoHelper
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

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

            Console.WriteLine(Currency1.Symbol(CurrencyType.EUR));
            Console.WriteLine(Currency1.Symbol(CurrencyType.USD));
            Console.WriteLine(Currency1.Symbol(CurrencyType.TRY));
            Console.WriteLine(Currency1.Symbol(CurrencyType.RUB));
            Console.WriteLine(Currency1.Symbol(CurrencyType.AFN));
            Console.WriteLine(Currency1.Symbol(CurrencyType.CHF));

            Console.WriteLine();

            Console.WriteLine(Currency2.Name);
            Console.WriteLine(Currency2.Symbol);
            Console.WriteLine(Currency2.SymbolName);
            Console.WriteLine(Currency2.NativeName);
            Console.WriteLine(Currency2.EnglishName);

            Console.WriteLine();

            Console.WriteLine(TimeZone.Name(TimeZoneType.GMT_Plus_00_00_UTC));
            Console.WriteLine(TimeZone.Name(TimeZoneType.GMT_Plus_03_00_Istanbul));
            Console.WriteLine(TimeZone.Name(TimeZoneType.GMT_Plus_10_00_Melbourne));
            Console.WriteLine(TimeZone.Name(TimeZoneType.GMT_Minus_02_00_Greenland));

            Console.WriteLine(TimeZone.Name(TimeZoneType.GMT_Minus_01_00_Cape_Verde_Island));
            Console.WriteLine(TimeZone.ShortName(TimeZoneType.GMT_Minus_01_00_Cape_Verde_Island));
            Console.WriteLine(TimeZone.CleanShortName(TimeZoneType.GMT_Minus_01_00_Cape_Verde_Island));

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