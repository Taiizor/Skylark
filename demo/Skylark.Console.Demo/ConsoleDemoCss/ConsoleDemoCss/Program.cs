using Skylark.Extension.Css;

namespace ConsoleDemoCss
{
    internal class Program
    {
        private const string Css = "@charset 'UTF-8';\n* {\r\n\tmargin: 0;\r\n\tpadding: 0;\r\n\t-webkit-text-size-adjust: none;\r\n}";

        static void Main()
        {
            string Minify = CssExtension.ToMinify(Css);
            Console.WriteLine(Minify);

            Console.WriteLine();

            string Beauty = CssExtension.ToBeauty(Minify);
            Console.WriteLine(Beauty);

            Console.ReadKey();
        }
    }
}