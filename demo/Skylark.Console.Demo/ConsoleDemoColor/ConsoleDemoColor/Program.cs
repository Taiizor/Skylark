using Skylark.Extension;
using Skylark.Helper;
using Skylark.Struct;
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

            Console.WriteLine(ColorExtension.RGBToHex(220, 20, 60, false, false));
            Console.WriteLine(ColorExtension.ARGBToHex(255, 220, 20, 60, true, true));

            Console.WriteLine();

            Console.WriteLine(ColorExtension.RGBToColor(220, 20, 60));
            Console.WriteLine(ColorExtension.ARGBToColor(255, 220, 20, 60));

            Console.WriteLine();

            Console.WriteLine(ColorExtension.HexToRGB("#DC143C"));
            Console.WriteLine(ColorExtension.HexToARGB("#FFDC143C"));

            Console.WriteLine();

            Console.WriteLine(ColorExtension.HexToColor("#DC143C").ToString());
            Console.WriteLine(ColorExtension.HexToColor("#00DC143C").ToString());
            Console.WriteLine(ColorExtension.HexToColor("#FFDC143C").ToString());

            Console.WriteLine();

            ColoriseStruct Blend1 = new(0, 0, 0);
            Console.WriteLine(Blend1.ToInt());
            Console.WriteLine(Blend1);

            Console.WriteLine("=====^^=====");

            ColoriseStruct Blend2 = new(255, 255, 255);
            Console.WriteLine(Blend2.ToInt());
            Console.WriteLine(Blend2);

            Console.WriteLine("=====^^=====");

            Console.WriteLine($"Blend (Mix): {Blend1.ToBlend(Blend2)}");

            Console.ReadKey();
        }
    }
}