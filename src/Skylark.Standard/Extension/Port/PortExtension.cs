using Skylark.Enum;
using System.Net.Sockets;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSMPPM = Skylark.Standard.Manage.Port.PortManage;

namespace Skylark.Standard.Extension.Port
{
    /// <summary>
    /// 
    /// </summary>
    public static class PortExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Port"></param>
        /// <returns></returns>
        public static string Info(int Port = MPPM.Port)
        {
            try
            {
                Port = HL.Clamp(Port, MPPM.MinPort, MPPM.MaxPort);

                MPPM.List.TryGetValue(Port, out string Result);

                if (string.IsNullOrEmpty(Result))
                {
                    Result = MPPM.Unknown;
                }

                return Result;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Port"></param>
        /// <returns></returns>
        public static async Task<string> InfoAsync(int Port = MPPM.Port)
        {
            return await Task.Run(() => Info(Port));
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
                Ports ??= MPPM.Ports;

                if (Ports.Length > MPPM.Count)
                {
                    throw new SE(MPPM.Error);
                }

                Dictionary<int, string> Result = new();

                foreach (int Port in Ports)
                {
                    int Socket = HL.Clamp(Port, MPPM.MinPort, MPPM.MaxPort);

                    if (!Result.ContainsKey(Socket))
                    {
                        Result.Add(Socket, Info(Socket));
                    }
                }

                return Result;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Ports"></param>
        /// <returns></returns>
        public static async Task<Dictionary<int, string>> InfoAsync(int[] Ports = null)
        {
            return await Task.Run(() => Info(Ports));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Port"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public static PortType Scan(string Address = MPPM.Address, int Port = MPPM.Port, int Timeout = MPPM.Timeout)
        {
            try
            {
                Address = HL.Parameter(Address, MPPM.Address);
                Port = HL.Clamp(Port, MPPM.MinPort, MPPM.MaxPort);
                Timeout = HL.Clamp(Timeout, MPPM.MinTimeout, MPPM.MaxTimeout);

                using TcpClient Client = new();

                IAsyncResult Result = Client.BeginConnect(Address, Port, null, null);

                using (Result.AsyncWaitHandle)
                {
                    if (Result.AsyncWaitHandle.WaitOne(MPPM.Timeout, false))
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
        /// <param name="Port"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public static async Task<PortType> ScanAsync(string Address = MPPM.Address, int Port = MPPM.Port, int Timeout = MPPM.Timeout)
        {
            return await Task.Run(() => Scan(Address, Port, Timeout));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Ports"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public static Dictionary<int, PortType> ScanMultiple(string Address = MPPM.Address, int[] Ports = null, int Timeout = MPPM.Timeout)
        {
            try
            {
                Ports ??= MPPM.Ports;

                if (Ports.Length > MPPM.Count)
                {
                    throw new SE(MPPM.Error);
                }

                Dictionary<int, PortType> Result = new();

                foreach (int Port in Ports)
                {
                    int Socket = HL.Clamp(Port, MPPM.MinPort, MPPM.MaxPort);

                    if (!Result.ContainsKey(Socket))
                    {
                        Result.Add(Socket, Scan(Address, Socket, Timeout));
                    }
                }

                return Result;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Ports"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public static async Task<Dictionary<int, PortType>> ScanMultipleAsync(string Address = MPPM.Address, int[] Ports = null, int Timeout = MPPM.Timeout)
        {
            return await Task.Run(() => ScanMultiple(Address, Ports, Timeout));
        }
    }
}