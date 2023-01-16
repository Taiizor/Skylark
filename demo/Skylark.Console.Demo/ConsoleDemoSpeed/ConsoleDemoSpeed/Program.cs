using Skylark.Extension;

namespace ConsoleDemoSpeed
{
    internal class Program
    {
        private const decimal Value = 1;

        static void Main()
        {
            decimal CmsMps = SpeedExtension.CmsToMps(Value);
            Console.WriteLine($"{Value} Cms -> Mps: {CmsMps}");

            decimal CmsKph = SpeedExtension.CmsToKph(Value);
            Console.WriteLine($"{Value} Cms -> Kph: {CmsKph}");

            decimal CmsFts = SpeedExtension.CmsToFts(Value);
            Console.WriteLine($"{Value} Cms -> Fts: {CmsFts}");

            decimal CmsMph = SpeedExtension.CmsToMph(Value);
            Console.WriteLine($"{Value} Cms -> Mph: {CmsMph}");

            decimal CmsKnot = SpeedExtension.CmsToKnot(Value);
            Console.WriteLine($"{Value} Cms -> Knot: {CmsKnot}");

            decimal CmsMach = SpeedExtension.CmsToMach(Value);
            Console.WriteLine($"{Value} Cms -> Mach: {CmsMach}");

            Console.WriteLine();
            
            decimal MpsCms = SpeedExtension.MpsToCms(Value);
            Console.WriteLine($"{Value} Mps -> Cms: {MpsCms}");

            decimal MpsKph = SpeedExtension.MpsToKph(Value);
            Console.WriteLine($"{Value} Mps -> Kph: {MpsKph}");

            decimal MpsFts = SpeedExtension.MpsToFts(Value);
            Console.WriteLine($"{Value} Mps -> Fts: {MpsFts}");

            decimal MpsMph = SpeedExtension.MpsToMph(Value);
            Console.WriteLine($"{Value} Mps -> Mph: {MpsMph}");

            decimal MpsKnot = SpeedExtension.MpsToKnot(Value);
            Console.WriteLine($"{Value} Mps -> Knot: {MpsKnot}");

            decimal MpsMach = SpeedExtension.MpsToMach(Value);
            Console.WriteLine($"{Value} Mps -> Mach: {MpsMach}");

            Console.WriteLine();











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