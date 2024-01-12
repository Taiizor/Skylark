using Skylark.Standard.Extension.Url;
using System.Text;

namespace ConsoleDemoUrl
{
    internal class Program
    {
        private const string Url = "https://www.google.com/search?q=Taiizor+Skylark";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string Encode = UrlExtension.Encode(Url);
            Console.WriteLine(Encode);

            string Decode = UrlExtension.Decode(Encode);
            Console.WriteLine(Decode);

            Console.ReadKey();
        }
    }
}