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
        /// <param name="Timeout"></param>
        /// <param name="Direction"></param>
        public static void SendMessage(string Server, string Pipe, string Message, int Timeout, PipeDirection Direction)
        {
            using NamedPipeClientStream Client = new(Server, Pipe, Direction);

            Client.Connect(Timeout);

            StreamWriter Writer = new(Client)
            {
                AutoFlush = true
            };

            Writer.Write(Message);

            Writer.Flush();
            Writer.Close();

            Client.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Server"></param>
        /// <param name="Pipe"></param>
        /// <param name="Timeout"></param>
        /// <param name="Direction"></param>
        /// <returns></returns>
        public static string ReceiveMessage(string Server, string Pipe, int Timeout, PipeDirection Direction)
        {
            using NamedPipeClientStream Client = new(Server, Pipe, Direction);

            Client.Connect(Timeout);

            StreamReader Reader = new(Client);

            string Message = Reader.ReadToEnd();

            Reader.Close();

            return Message;
        }
    }
}