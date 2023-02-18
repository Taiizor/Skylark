using Skylark.Extension.Url;

namespace ConsoleDemoUrl
{
    internal class Program
    {
        private const string Url = "https://www.google.com/search?q=Taiizor+Skylark";

        static void Main()
        {
            string Encode = UrlExtension.Encode(Url);
            Console.WriteLine(Encode);

            string Decode = UrlExtension.Decode(Encode);
            Console.WriteLine(Decode);

            Console.ReadKey();
        }
    }
}