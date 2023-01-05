using Skylark.Helper;

namespace ConsoleDemoHelper
{
    internal class Program
    {
        static void Main()
        {
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