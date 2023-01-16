using Skylark.Extension;

namespace ConsoleDemoSpeed
{
    internal class Program
    {
        private const decimal Value = 60;

        static void Main()
        {
            decimal MpsMph = SpeedExtension.MpsToMph(Value);
            Console.WriteLine($"{Value} Mps -> Mph: {MpsMph}");

            Console.WriteLine();

            decimal MpsKph = SpeedExtension.MpsToKph(Value);
            Console.WriteLine($"{Value} Mps -> Kph: {MpsKph}");

            Console.WriteLine();

            decimal MphMps = SpeedExtension.MphToMps(Value);
            Console.WriteLine($"{Value} Mph -> Mps: {MphMps}");

            Console.WriteLine();

            decimal MphKph = SpeedExtension.MphToKph(Value);
            Console.WriteLine($"{Value} Mph -> Kph: {MphKph}");

            Console.WriteLine();

            decimal KphMps = SpeedExtension.KphToMps(Value);
            Console.WriteLine($"{Value} Kph -> Mps: {KphMps}");

            Console.WriteLine();

            decimal KphMph = SpeedExtension.KphToMph(Value);
            Console.WriteLine($"{Value} Kph -> Mph: {KphMph}");

            Console.ReadKey();
        }
    }
}