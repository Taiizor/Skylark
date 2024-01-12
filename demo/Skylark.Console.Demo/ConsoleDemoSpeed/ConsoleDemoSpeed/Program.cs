using Skylark.Standard.Extension.Speed;
using System.Text;

namespace ConsoleDemoSpeed
{
    internal class Program
    {
        private const decimal Value = 1;

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

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

            decimal KphCms = SpeedExtension.KphToCms(Value);
            Console.WriteLine($"{Value} Kph -> Cms: {KphCms}");

            decimal KphMps = SpeedExtension.KphToMps(Value);
            Console.WriteLine($"{Value} Kph -> Mps: {KphMps}");

            decimal KphFts = SpeedExtension.KphToFts(Value);
            Console.WriteLine($"{Value} Kph -> Fts: {KphFts}");

            decimal KphMph = SpeedExtension.KphToMph(Value);
            Console.WriteLine($"{Value} Kph -> Mph: {KphMph}");

            decimal KphKnot = SpeedExtension.KphToKnot(Value);
            Console.WriteLine($"{Value} Kph -> Knot: {KphKnot}");

            decimal KphMach = SpeedExtension.KphToMach(Value);
            Console.WriteLine($"{Value} Kph -> Mach: {KphMach}");

            Console.WriteLine();

            decimal FtsCms = SpeedExtension.FtsToCms(Value);
            Console.WriteLine($"{Value} Fts -> Cms: {FtsCms}");

            decimal FtsMps = SpeedExtension.FtsToMps(Value);
            Console.WriteLine($"{Value} Fts -> Mps: {FtsMps}");

            decimal FtsKph = SpeedExtension.FtsToKph(Value);
            Console.WriteLine($"{Value} Fts -> Kph: {FtsKph}");

            decimal FtsMph = SpeedExtension.FtsToMph(Value);
            Console.WriteLine($"{Value} Fts -> Mph: {FtsMph}");

            decimal FtsKnot = SpeedExtension.FtsToKnot(Value);
            Console.WriteLine($"{Value} Fts -> Knot: {FtsKnot}");

            decimal FtsMach = SpeedExtension.FtsToMach(Value);
            Console.WriteLine($"{Value} Fts -> Mach: {FtsMach}");

            Console.WriteLine();

            decimal MphCms = SpeedExtension.MphToCms(Value);
            Console.WriteLine($"{Value} Mph -> Cms: {MphCms}");

            decimal MphMps = SpeedExtension.MphToMps(Value);
            Console.WriteLine($"{Value} Mph -> Mps: {MphMps}");

            decimal MphKph = SpeedExtension.MphToKph(Value);
            Console.WriteLine($"{Value} Mph -> Kph: {MphKph}");

            decimal MphFts = SpeedExtension.MphToFts(Value);
            Console.WriteLine($"{Value} Mph -> Fts: {MphFts}");

            decimal MphKnot = SpeedExtension.MphToKnot(Value);
            Console.WriteLine($"{Value} Mph -> Knot: {MphKnot}");

            decimal MphMach = SpeedExtension.MphToMach(Value);
            Console.WriteLine($"{Value} Mph -> Mach: {MphMach}");

            Console.WriteLine();

            decimal KnotCms = SpeedExtension.KnotToCms(Value);
            Console.WriteLine($"{Value} Knot -> Cms: {KnotCms}");

            decimal KnotMps = SpeedExtension.KnotToMps(Value);
            Console.WriteLine($"{Value} Knot -> Mps: {KnotMps}");

            decimal KnotKph = SpeedExtension.KnotToKph(Value);
            Console.WriteLine($"{Value} Knot -> Kph: {KnotKph}");

            decimal KnotFts = SpeedExtension.KnotToFts(Value);
            Console.WriteLine($"{Value} Knot -> Fts: {KnotFts}");

            decimal KnotMph = SpeedExtension.KnotToMph(Value);
            Console.WriteLine($"{Value} Knot -> Mph: {KnotMph}");

            decimal KnotMach = SpeedExtension.KnotToMach(Value);
            Console.WriteLine($"{Value} Knot -> Mach: {KnotMach}");

            Console.WriteLine();

            decimal MachCms = SpeedExtension.MachToCms(Value);
            Console.WriteLine($"{Value} Mach -> Cms: {MachCms}");

            decimal MachMps = SpeedExtension.MachToMps(Value);
            Console.WriteLine($"{Value} Mach -> Mps: {MachMps}");

            decimal MachKph = SpeedExtension.MachToKph(Value);
            Console.WriteLine($"{Value} Mach -> Kph: {MachKph}");

            decimal MachFts = SpeedExtension.MachToFts(Value);
            Console.WriteLine($"{Value} Mach -> Fts: {MachFts}");

            decimal MachMph = SpeedExtension.MachToMph(Value);
            Console.WriteLine($"{Value} Mach -> Mph: {MachMph}");

            decimal MachKnot = SpeedExtension.MachToKnot(Value);
            Console.WriteLine($"{Value} Mach -> Knot: {MachKnot}");

            Console.ReadKey();
        }
    }
}