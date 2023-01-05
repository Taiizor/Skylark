using Skylark.Enum;
using Skylark.Extension;
using Skylark.Struct;

namespace ConsoleDemoWeb
{
    internal class Program
    {
        private const string Css = "@charset 'UTF-8';\n* {\r\n\tmargin: 0;\r\n\tpadding: 0;\r\n\t-webkit-text-size-adjust: none;\r\n}";

        static void Main()
        {
            string Source = WebExtension.Source("https://www.bing.com");
            Console.WriteLine($"Source (Cut): {Source[..512]}...");

            Console.WriteLine();

            CompressWebType Compress = WebExtension.Compress("https://www.bing.com");
            Console.WriteLine($"Compress Type: {Compress}");

            Console.WriteLine();

            string Similar = WebExtension.Similar("https://www.vegalya.com", "https://www.vegalya.com");
            Console.WriteLine($"Similarity: %{Similar}");

            Console.WriteLine();

            WebRatioStruct Ratio = WebExtension.Ratio("https://www.bing.com");
            Console.WriteLine($"Code: {Ratio.Code}");
            Console.WriteLine($"Text: {Ratio.Text}");
            Console.WriteLine($"Rate: %{Ratio.Rate}");
            Console.WriteLine($"Total: {Ratio.Total}");

            Console.WriteLine();

            WebHeaderStruct Header = WebExtension.Header("https://www.google.com");
            Console.WriteLine($"Age: {Header.Age}");
            Console.WriteLine($"Date: {Header.Date}");
            Console.WriteLine($"Vary: {Header.Vary}");
            Console.WriteLine($"ETag: {Header.ETag}");
            Console.WriteLine($"Type: {Header.Type}");
            Console.WriteLine($"Cache: {Header.Cache}");
            Console.WriteLine($"Cookie: {Header.Cookie}");
            Console.WriteLine($"Length: {Header.Length}");
            Console.WriteLine($"Server: {Header.Server}");
            Console.WriteLine($"Ranges: {Header.Ranges}");
            Console.WriteLine($"Reason: {Header.Reason}");
            Console.WriteLine($"Status: {Header.Status}");
            Console.WriteLine($"Success: {Header.Success}");
            Console.WriteLine($"Version: {Header.Version}");
            Console.WriteLine($"Modified: {Header.Modified}");
            Console.WriteLine($"Security: {Header.Security}");

            Console.ReadKey();
        }
    }
}