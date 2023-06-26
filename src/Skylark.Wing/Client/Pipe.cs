using System.IO;
using System.IO.Pipes;

namespace Skylark.Wing.Client
{
    public static class Pipe
    {
        public static void SendMessage(string ChannelName, string Message)
        {
            using NamedPipeClientStream PipeClient = new(".", ChannelName, PipeDirection.Out);

            PipeClient.Connect(0);

            StreamWriter writer = new(PipeClient)
            {
                AutoFlush = true
            };

            writer.Write(Message);

            writer.Flush();
            writer.Close();

            PipeClient.Dispose();
        }
    }
}