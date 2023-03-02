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

            Console.WriteLine(Uptiming.Service("http"));
            Console.WriteLine(Uptiming.Service("https"));
            Console.WriteLine(Uptiming.Service("smtp"));
            Console.WriteLine(Uptiming.Service("pop3"));
            Console.WriteLine(Uptiming.Service("imap"));
            Console.WriteLine(Uptiming.Service("ftp"));
            Console.WriteLine(Uptiming.Service("ssh"));

            Console.ReadKey();
        }
    }
}