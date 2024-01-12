using Skylark.Standard.Extension.Html;
using System.Text;

namespace ConsoleDemoHtml
{
    internal class Program
    {
        private const string Html = "<html>\n\t<head>\n\t\t<title>Taiizor Skylark</title>\n\t</head>\n</html>";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string Encode = HtmlExtension.Encode(Html);
            Console.WriteLine(Encode);

            string Decode = HtmlExtension.Decode(Encode);
            Console.WriteLine(Decode);

            Console.WriteLine();

            string Minify = HtmlExtension.ToMinify(Html);
            Console.WriteLine(Minify);

            Console.WriteLine();

            string Beauty = HtmlExtension.ToBeauty(Minify);
            Console.WriteLine(Beauty);

            Console.ReadKey();
        }
    }
}