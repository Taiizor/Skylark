using Skylark.Standard.Extension.Xml;
using System.Text;

namespace ConsoleDemoXml
{
    internal class Program
    {
        private const string Xml = "<?xml version='1.0' standalone='no'?>\n<Root>\n\n<Taiizor>Skylark</Taiizor></Root>";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string Json = XmlExtension.ToJson(Xml);
            Console.WriteLine(Json);

            Console.WriteLine();

            string Minify = XmlExtension.ToMinify(Xml);
            Console.WriteLine(Minify);

            Console.WriteLine();

            string Beauty = XmlExtension.ToBeauty(Minify);
            Console.WriteLine(Beauty);

            Console.ReadKey();
        }
    }
}