using Skylark.Extension;

namespace ConsoleDemoXhtml
{
    internal class Program
    {
        private const string Xhtml = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD XHTML 1.1//EN\"\r\n\"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xmlns=\"http://www.w3.org/1999/xhtml\">\n\t<head>\n\t\t<title>Taiizor Skylark</title>\n\t</head>\n</html>";

        static void Main()
        {
            string Minify = XhtmlExtension.ToMinify(Xhtml);
            Console.WriteLine(Minify);

            Console.WriteLine();

            string Beauty = XhtmlExtension.ToBeauty(Minify);
            Console.WriteLine(Beauty);

            Console.ReadKey();
        }
    }
}