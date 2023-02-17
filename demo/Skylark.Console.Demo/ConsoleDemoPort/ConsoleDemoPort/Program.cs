using Skylark.Enum;
using Skylark.Extension;

namespace ConsoleDemoPort
{
    internal class Program
    {
        static void Main()
        {
            string Info1 = PortExtension.Info(443);
            Console.WriteLine(Info1);

            Console.WriteLine();

            Dictionary<int, string> Info2 = PortExtension.Info(new[] { 21, 22, 53, 80, 110, 143, 587, 3306 });
            foreach (KeyValuePair<int, string> Pair in Info2)
            {
                Console.WriteLine($"{Pair.Key}: {Pair.Value}");
            }

            Console.WriteLine();

            PortType Scan1 = PortExtension.Scan("www.google.com", 443, 1000);
            Console.WriteLine(Scan1);

            Console.WriteLine();

            Dictionary<int, PortType> ScanMultiple = PortExtension.ScanMultiple("www.google.com", new[] { 21, 80, 443 }, 500);
            foreach (KeyValuePair<int, PortType> Pair in ScanMultiple)
            {
                Console.WriteLine($"{Pair.Key}: {Pair.Value}");
            }

            Console.ReadKey();
        }
    }
}