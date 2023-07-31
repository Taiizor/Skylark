using System.IO;
using System.IO.Pipes;

namespace Skylark.Wing.Client
{
    /// <summary>
    /// 
    /// </summary>
    public static class Pipe
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Server"></param>
        /// <param name="Pipe"></param>
        /// <param name="Message"></param>
        /// <param name="Direction"></param>
        public static void SendMessage(string Server, string Pipe, string Message, PipeDirection Direction)
        {
            using NamedPipeClientStream Client = new(Server, Pipe, Direction);

            Client.Connect(0);

            StreamWriter Writer = new(Client)
            {
                AutoFlush = true
            };

            Writer.Write(Message);

            Writer.Flush();
            Writer.Close();

            Client.Dispose();
        }
    }
}