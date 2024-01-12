﻿using Skylark.Standard.Extension.Css;
using System.Text;

namespace ConsoleDemoCss
{
    internal class Program
    {
        private const string Css = "@charset 'UTF-8';\n* {\r\n\tmargin: 0;\r\n\tpadding: 0;\r\n\t-webkit-text-size-adjust: none;\r\n}";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string Minify = CssExtension.ToMinify(Css);
            Console.WriteLine(Minify);

            Console.WriteLine();

            string Beauty = CssExtension.ToBeauty(Minify);
            Console.WriteLine(Beauty);

            Console.ReadKey();
        }
    }
}