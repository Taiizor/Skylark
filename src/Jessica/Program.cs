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

            string Address = Console.ReadLine();

            Uptimer Uptiming = new(Address);

            PingSendStruct Pong = Uptiming.Ping();

            Console.WriteLine($"Address: {Pong.Address} ({Address})");
            Console.WriteLine($"Status: {Pong.Result}");
            Console.WriteLine($"Ping: {Pong.RoundTrip} MS");

            Console.WriteLine();

            CertificateStruct Certificate = await Uptiming.Certificate();

            Console.WriteLine($"Certificate State: {Certificate.State}");
            Console.WriteLine($"Certificate Remaining Days: {Certificate.RemainingDays}");
            Console.WriteLine($"Certificate Expiration Date Time: {Certificate.ExpirationDateTime}");

            Console.WriteLine();

            Console.WriteLine($"Oracle Service: {Uptiming.Service(ServiceType.Oracle)}");
            Console.WriteLine($"MSSQL Service: {Uptiming.Service(ServiceType.MSSQL)}");
            Console.WriteLine($"MySQL Service: {Uptiming.Service(ServiceType.MySQL)}");
            Console.WriteLine($"HTTPS Service: {Uptiming.Service(ServiceType.HTTPS)}");
            Console.WriteLine($"HTTP Service: {Uptiming.Service(ServiceType.HTTP)}");
            Console.WriteLine($"SMTP Service: {Uptiming.Service(ServiceType.SMTP)}");
            Console.WriteLine($"POP3 Service: {Uptiming.Service(ServiceType.POP3)}");
            Console.WriteLine($"IMAP Service: {Uptiming.Service(ServiceType.IMAP)}");
            Console.WriteLine($"RDP Service: {Uptiming.Service(ServiceType.RDP)}");
            Console.WriteLine($"NTP Service: {Uptiming.Service(ServiceType.NTP)}");
            Console.WriteLine($"FTP Service: {Uptiming.Service(ServiceType.FTP)}");
            Console.WriteLine($"SSH Service: {Uptiming.Service(ServiceType.SSH)}");
            Console.WriteLine($"DNS Service: {Uptiming.Service(ServiceType.DNS)}");

            Console.ReadKey();

            await Task.CompletedTask;
        }
    }
}