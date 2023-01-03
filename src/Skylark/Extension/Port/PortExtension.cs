using Skylark.Enum;
using System.Net.Sockets;
using HL = Skylark.Helper.Length;
using MPM = Skylark.Manage.PortManage;

namespace Skylark.Extension
{
    public class PortExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Port"></param>
        /// <returns></returns>
        public static string Info(int Port = MPM.Port)
        {
            try
            {
                Port = HL.Number(Port, MPM.MinPort, MPM.MaxPort);

                MPM.List.TryGetValue(Port, out string Result);

                if (string.IsNullOrEmpty(Result))
                {
                    Result = MPM.Unknown;
                }

                return Result;
            }
            catch
            {
                return MPM.Unknown;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Ports"></param>
        /// <returns></returns>
        public static Dictionary<int, string> Info(int[] Ports = null)
        {
            try
            {
                Ports ??= MPM.Ports;

                if (Ports.Length > 10)
                {
                    Ports = MPM.Ports;
                }

                Dictionary<int, string> Result = new();

                foreach (int Port in Ports)
                {
                    int Socket = HL.Number(Port, MPM.MinPort, MPM.MaxPort);

                    if (!Result.ContainsKey(Socket))
                    {
                        Result.Add(Socket, Info(Socket));
                    }
                }

                return Result;
            }
            catch
            {
                return new();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Port"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public static PortType Scan(string Address = MPM.Address, int Port = MPM.Port, int Timeout = MPM.Timeout)
        {
            try
            {
                Address = HL.Parameter(Address, MPM.Address);
                Port = HL.Number(Port, MPM.MinPort, MPM.MaxPort);
                Timeout = HL.Number(Timeout, MPM.MinTimeout, MPM.MaxTimeout);

                using TcpClient Client = new();

                IAsyncResult Result = Client.BeginConnect(Address, Port, null, null);

                using (Result.AsyncWaitHandle)
                {
                    if (Result.AsyncWaitHandle.WaitOne(MPM.Timeout, false))
                    {
                        Client.EndConnect(Result);
                        return PortType.Open;
                    }
                    else
                    {
                        return PortType.Close;
                    }
                }
            }
            catch
            {
                return PortType.Close;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Ports"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public static Dictionary<int, PortType> Scan(string Address = MPM.Address, int[] Ports = null, int Timeout = MPM.Timeout)
        {
            try
            {
                Ports ??= MPM.Ports;

                if (Ports.Length > 10)
                {
                    Ports = MPM.Ports;
                }

                Dictionary<int, PortType> Result = new();

                foreach (int Port in Ports)
                {
                    int Socket = HL.Number(Port, MPM.MinPort, MPM.MaxPort);

                    if (!Result.ContainsKey(Socket))
                    {
                        Result.Add(Socket, Scan(Address, Socket, Timeout));
                    }
                }

                return Result;
            }
            catch
            {
                return new();
            }
        }
    }
}