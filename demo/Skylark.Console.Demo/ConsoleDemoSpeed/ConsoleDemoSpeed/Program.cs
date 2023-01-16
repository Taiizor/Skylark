using Skylark.Extension;

namespace ConsoleDemoSpeed
{
    internal class Program
    {
        private const decimal Value = 10000;

        static void Main()
        {
            decimal CmsMps = SpeedExtension.CmpsToMps(Value);
            Console.WriteLine($"{Value} Cms -> Mps: {CmsMps}");

            Console.WriteLine();









            decimal MpsMph = SpeedExtension.MpsToMph(Value);
            Console.WriteLine($"{Value} Mps -> Mph: {MpsMph}");

            Console.WriteLine();

            decimal MpsKph = SpeedExtension.MpsToKph(Value);
            Console.WriteLine($"{Value} Mps -> Kph: {MpsKph}");

            Console.WriteLine();

            decimal MpsFts = SpeedExtension.MpsToFts(Value);
            Console.WriteLine($"{Value} Mps -> Fts: {MpsFts}");

            Console.WriteLine();

            decimal MpsKnot = SpeedExtension.MpsToKnot(Value);
            Console.WriteLine($"{Value} Mps -> Knot: {MpsKnot}");

            Console.WriteLine();

            decimal MpsMach = SpeedExtension.MpsToMach(Value);
            Console.WriteLine($"{Value} Mps -> Mach: {MpsMach}");

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