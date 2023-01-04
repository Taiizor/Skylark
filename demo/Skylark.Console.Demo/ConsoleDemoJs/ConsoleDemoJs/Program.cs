using Skylark.Extension;

namespace ConsoleDemoJs
{
    internal class Program
    {
        private const string Js = "Taiizor = function(message = 'Skylark')\r\n{\r\n\tconsole.log(message);\r\n}";

        static void Main()
        {
            string Minify = JsExtension.ToMinify(Js);
            Console.WriteLine(Minify);

            Console.WriteLine();

            string Beauty = JsExtension.ToBeauty(Minify);
            Console.WriteLine(Beauty);
        }
    }
}