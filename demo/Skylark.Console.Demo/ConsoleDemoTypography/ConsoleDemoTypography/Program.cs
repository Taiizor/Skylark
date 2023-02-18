using Skylark.Extension.Typography;

namespace ConsoleDemoTypography
{
    internal class Program
    {
        private const decimal Value = 999;

        static void Main()
        {
            decimal PI = TypographyExtension.PixelToInch(Value);
            Console.WriteLine($"{Value} Pixel -> Inch: {PI}");

            decimal PP = TypographyExtension.PixelToPunto(Value);
            Console.WriteLine($"{Value} Pixel -> Punto: {PP}");

            decimal PC = TypographyExtension.PixelToCentimeter(Value);
            Console.WriteLine($"{Value} Pixel -> Centimeter: {PC}");

            Console.WriteLine();

            decimal IPL = TypographyExtension.InchToPixel(Value);
            Console.WriteLine($"{Value} Inch -> Pixel: {IPL}");

            decimal IPO = TypographyExtension.InchToPunto(Value);
            Console.WriteLine($"{Value} Inch -> Punto: {IPO}");

            decimal IC = TypographyExtension.InchToCentimeter(Value);
            Console.WriteLine($"{Value} Inch -> Centimeter: {IC}");

            Console.WriteLine();

            decimal POP = TypographyExtension.PuntoToPixel(Value);
            Console.WriteLine($"{Value} Punto -> Pixel: {POP}");

            decimal POI = TypographyExtension.PuntoToInch(Value);
            Console.WriteLine($"{Value} Punto -> Inch: {POI}");

            decimal POC = TypographyExtension.PuntoToCentimeter(Value);
            Console.WriteLine($"{Value} Punto -> Centimeter: {POC}");

            Console.WriteLine();

            decimal CPL = TypographyExtension.CentimeterToPixel(Value);
            Console.WriteLine($"{Value} Centimeter -> Pixel: {CPL}");

            decimal CI = TypographyExtension.CentimeterToInch(Value);
            Console.WriteLine($"{Value} Centimeter -> Inch: {CI}");

            decimal CPO = TypographyExtension.CentimeterToPunto(Value);
            Console.WriteLine($"{Value} Centimeter -> Punto: {CPO}");

            Console.ReadKey();
        }
    }
}