using Skylark.Extension.Xml;

namespace ConsoleDemoXml
{
    internal class Program
    {
        private const string Xml = "<?xml version='1.0' standalone='no'?>\n<Root>\n\n<Taiizor>Skylark</Taiizor></Root>";

        static void Main()
        {
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