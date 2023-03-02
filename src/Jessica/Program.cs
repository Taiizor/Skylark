using Skylark.Enum;
using Skylark.Struct.Ping;
using Skylark.Uptime;

namespace Jessica
{
    internal class Program
    {
        static void Main()
        {
            Uptimer Uptiming = new("127.0.0.1");

            PingSendStruct Pong = Uptiming.Ping();

            Console.WriteLine(Pong.Result);
            Console.WriteLine(Pong.RoundTrip);

            Console.WriteLine(Uptiming.Service(ServiceUptimeType.HTTPS));
            Console.WriteLine(Uptiming.Service(ServiceUptimeType.HTTP));
            Console.WriteLine(Uptiming.Service(ServiceUptimeType.SMTP));
            Console.WriteLine(Uptiming.Service(ServiceUptimeType.POP3));
            Console.WriteLine(Uptiming.Service(ServiceUptimeType.IMAP));
            Console.WriteLine(Uptiming.Service(ServiceUptimeType.FTP));
            Console.WriteLine(Uptiming.Service(ServiceUptimeType.SSH));

            Console.ReadKey();
        }
    }
}