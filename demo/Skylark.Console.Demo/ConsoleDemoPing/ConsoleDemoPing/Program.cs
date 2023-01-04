using Skylark.Extension;
using Skylark.Struct;

namespace ConsoleDemoPing
{
    internal class Program
    {
        static void Main()
        {
            PingSendStruct Send1 = PingExtension.Send("www.google.com");
            Console.WriteLine($"Ttl: {Send1.Ttl}");
            Console.WriteLine($"Buffer: {Send1.Buffer}");
            Console.WriteLine($"Result: {Send1.Result}");
            Console.WriteLine($"Address: {Send1.Address}");
            Console.WriteLine($"Fragment: {Send1.Fragment}");
            Console.WriteLine($"RoundTrip: {Send1.RoundTrip}");

            Console.WriteLine();

            PingSendStruct Send2 = PingExtension.Send("www.bing.com", 3000);
            Console.WriteLine($"Ttl: {Send2.Ttl}");
            Console.WriteLine($"Buffer: {Send2.Buffer}");
            Console.WriteLine($"Result: {Send2.Result}");
            Console.WriteLine($"Address: {Send2.Address}");
            Console.WriteLine($"Fragment: {Send2.Fragment}");
            Console.WriteLine($"RoundTrip: {Send2.RoundTrip}");

            Console.WriteLine();

            PingSendStruct Send3 = PingExtension.Send("www.yahoo.com", 3000, 64);
            Console.WriteLine($"Ttl: {Send3.Ttl}");
            Console.WriteLine($"Buffer: {Send3.Buffer}");
            Console.WriteLine($"Result: {Send3.Result}");
            Console.WriteLine($"Address: {Send3.Address}");
            Console.WriteLine($"Fragment: {Send3.Fragment}");
            Console.WriteLine($"RoundTrip: {Send3.RoundTrip}");

            Console.WriteLine();

            PingSendStruct Send4 = PingExtension.Send("www.yandex.com", 3000, 64, true);
            Console.WriteLine($"Ttl: {Send4.Ttl}");
            Console.WriteLine($"Buffer: {Send4.Buffer}");
            Console.WriteLine($"Result: {Send4.Result}");
            Console.WriteLine($"Address: {Send4.Address}");
            Console.WriteLine($"Fragment: {Send4.Fragment}");
            Console.WriteLine($"RoundTrip: {Send4.RoundTrip}");
        }
    }
}