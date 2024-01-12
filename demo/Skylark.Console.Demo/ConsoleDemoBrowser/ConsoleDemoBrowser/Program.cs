using Newtonsoft.Json;
using Skylark.Standard.Extension.Browser;
using Skylark.Struct.Browser;
using System.Text;

namespace ConsoleDemoBrowser
{
    internal class Program
    {
        private const string UserAgent = "Mozilla/5.0 (Windows NT 11.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36 Edg/120.0.0.0";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"User Agent: {UserAgent}");

            Console.WriteLine();

            BrowserStruct Result = BrowserExtension.Parse(UserAgent);
            Console.WriteLine(JsonConvert.SerializeObject(Result, Formatting.Indented));

            Console.WriteLine();

            Console.WriteLine($"Robot: {BrowserExtension.Robot(UserAgent)}");
            Console.WriteLine($"Mobile: {BrowserExtension.Mobile(UserAgent)}");
            Console.WriteLine($"RobotIs: {BrowserExtension.RobotIs(UserAgent)}");
            Console.WriteLine($"Browser: {BrowserExtension.Browser(UserAgent)}");
            Console.WriteLine($"MobileIs: {BrowserExtension.MobileIs(UserAgent)}");
            Console.WriteLine($"Platform: {BrowserExtension.Platform(UserAgent)}");
            Console.WriteLine($"BrowserIs: {BrowserExtension.BrowserIs(UserAgent)}");
            Console.WriteLine($"BrowserVersion: {BrowserExtension.BrowserVersion(UserAgent)}");

            Console.ReadKey();
        }
    }
}