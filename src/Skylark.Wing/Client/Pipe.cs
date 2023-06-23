using System.IO;
using System.IO.Pipes;

namespace Skylark.Wing.Client
{
    public static class Pipe
    {
        public static void SendMessage(string channelName, string msg)
        {
            using NamedPipeClientStream pipeClient = new(".", channelName, PipeDirection.Out);
            pipeClient.Connect(0);
            StreamWriter writer = new(pipeClient) { AutoFlush = true };
            writer.Write(msg);
            writer.Flush();
            writer.Close();
            pipeClient.Dispose();
        }
    }
}