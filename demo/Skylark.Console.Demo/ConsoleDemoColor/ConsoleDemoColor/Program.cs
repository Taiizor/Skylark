using Skylark.Extension;
using System.Drawing;

namespace ConsoleDemoColor
{
    internal class Program
    {
        private static readonly Color Color = Color.Crimson;

        static void Main()
        {
            Console.WriteLine(Color.ToString());

            Console.WriteLine();

            Console.WriteLine(ColorExtension.ToHex(Color, false, false));
            Console.WriteLine(ColorExtension.ToHex(Color, true, true));
            
            Console.WriteLine(ColorExtension.ToHexInteger(Color, false, false));
            Console.WriteLine(ColorExtension.ToHexInteger(Color, true, true));

            Console.WriteLine();

            Console.WriteLine(ColorExtension.ToRGB(Color));

            Console.WriteLine(ColorExtension.ToHSB(Color));

            Console.WriteLine(ColorExtension.ToHSI(Color));

            Console.WriteLine(ColorExtension.ToHSL(Color));

            Console.WriteLine(ColorExtension.ToHSV(Color));

            Console.WriteLine(ColorExtension.ToHWB(Color));

            Console.WriteLine(ColorExtension.ToARGB(Color));

            Console.WriteLine(ColorExtension.ToCMYK(Color));

            Console.WriteLine(ColorExtension.ToCIELAB(Color));

            Console.WriteLine(ColorExtension.ToCIEXYZ(Color));

            Console.WriteLine(ColorExtension.ToNatural(Color));

            Console.WriteLine();

            Console.WriteLine(ColorExtension.ToFloat(Color));
            Console.WriteLine(ColorExtension.ToDecimal(Color));

            Console.WriteLine();

            Console.WriteLine(ColorExtension.HexToRGB("#DC143C"));

            Console.ReadKey();
        }
    }
}