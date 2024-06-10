using Skylark.Enum;
using Skylark.Struct.Certificate;
using Skylark.Struct.Ping;
using Skylark.Uptime;

namespace Jessica
{
    internal class Program
    {
        public static async Task Main()
        {
            Console.Write("Enter Address: ");

            string Address = Console.ReadLine() ?? string.Empty;

            Uptimer Uptiming = new(Address);

            PingSendStruct Pong = Uptiming.Ping(3000);

            Console.WriteLine($"Address: {Pong.Address} ({Address})");
            Console.WriteLine($"Status: {Pong.Result}");
            Console.WriteLine($"Ping: {Pong.RoundTrip} MS");

            Console.WriteLine();

            CertificateStruct Certificate = await Uptiming.Certificate(3000);

            Console.WriteLine($"Certificate State: {Certificate.State}");
            Console.WriteLine($"Certificate Remaining Days: {Certificate.RemainingDays}");
            Console.WriteLine($"Certificate Expiration Date Time: {Certificate.ExpirationDateTime}");

            Console.WriteLine();

            Console.WriteLine($"MongoDB Service: {Uptiming.Service(ServiceType.MongoDB, 500)}");
            Console.WriteLine($"Oracle Service: {Uptiming.Service(ServiceType.Oracle, 500)}");
            Console.WriteLine($"MSSQL Service: {Uptiming.Service(ServiceType.MSSQL, 500)}");
            Console.WriteLine($"MySQL Service: {Uptiming.Service(ServiceType.MySQL, 500)}");
            Console.WriteLine($"HTTPS Service: {Uptiming.Service(ServiceType.HTTPS, 500)}");
            Console.WriteLine($"HTTP Service: {Uptiming.Service(ServiceType.HTTP, 500)}");
            Console.WriteLine($"SMTP Service: {Uptiming.Service(ServiceType.SMTP, 500)}");
            Console.WriteLine($"POP3 Service: {Uptiming.Service(ServiceType.POP3, 500)}");
            Console.WriteLine($"IMAP Service: {Uptiming.Service(ServiceType.IMAP, 500)}");
            Console.WriteLine($"RDP Service: {Uptiming.Service(ServiceType.RDP, 500)}");
            Console.WriteLine($"NTP Service: {Uptiming.Service(ServiceType.NTP, 500)}");
            Console.WriteLine($"FTP Service: {Uptiming.Service(ServiceType.FTP, 500)}");
            Console.WriteLine($"SSH Service: {Uptiming.Service(ServiceType.SSH, 500)}");
            Console.WriteLine($"DNS Service: {Uptiming.Service(ServiceType.DNS, 500)}");

            Console.ReadKey();

            await Task.CompletedTask;
        }
    }
}