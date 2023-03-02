using Skylark.Enum;
using Skylark.Struct.Certificate;
using Skylark.Struct.Ping;
using Skylark.Uptime;

namespace Jessica
{
    internal class Program
    {
        static void Main()
        {
            Uptimer Uptiming = new("www.bing.com");

            PingSendStruct Pong = Uptiming.Ping();

            Console.WriteLine($"Address: {Pong.Address} (www.bing.com)");
            Console.WriteLine($"Status: {Pong.Result}");
            Console.WriteLine($"Ping: {Pong.RoundTrip} MS");

            Console.WriteLine();

            CertificateStruct Certificate = Uptiming.Certificate().Result;

            Console.WriteLine($"Certificate State: {Certificate.State}");
            Console.WriteLine($"Certificate Remaining Days: {Certificate.RemainingDays}");
            Console.WriteLine($"Certificate Expiration Date Time: {Certificate.ExpirationDateTime}");

            Console.WriteLine();

            Console.WriteLine($"HTTPS Service: {Uptiming.Service(ServiceType.HTTPS)}");
            Console.WriteLine($"HTTP Service: {Uptiming.Service(ServiceType.HTTP)}");
            Console.WriteLine($"SMTP Service: {Uptiming.Service(ServiceType.SMTP)}");
            Console.WriteLine($"POP3 Service: {Uptiming.Service(ServiceType.POP3)}");
            Console.WriteLine($"IMAP Service: {Uptiming.Service(ServiceType.IMAP)}");
            Console.WriteLine($"FTP Service: {Uptiming.Service(ServiceType.FTP)}");
            Console.WriteLine($"SSH Service: {Uptiming.Service(ServiceType.SSH)}");

            Console.ReadKey();
        }
    }
}