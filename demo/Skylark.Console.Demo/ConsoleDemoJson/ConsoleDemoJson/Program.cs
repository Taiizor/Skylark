using Skylark.Standard.Extension.Json;
using System.Text;

namespace ConsoleDemoJson
{
    internal class Program
    {
        private const string Json = "{\r\n\t\"Taiizor\": \"Skylark\"\r\n}";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string Xml = JsonExtension.ToXml(Json);
            Console.WriteLine(Xml);

            Console.WriteLine();

            string Read = JsonExtension.ToRead(Json);
            Console.WriteLine(Read);

            Console.WriteLine();

            string Minify = JsonExtension.ToMinify(Json);
            Console.WriteLine(Minify);

            Console.WriteLine();

            string Beauty = JsonExtension.ToBeauty(Minify);
            Console.WriteLine(Beauty);

            Console.WriteLine();

            dynamic Expando = JsonExtension.ToExpando(Json);
            Console.WriteLine(Expando.Taiizor);

            Console.ReadKey();
        }
    }
}