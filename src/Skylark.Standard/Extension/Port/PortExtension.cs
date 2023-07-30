using System.Net.Sockets;
using SE = Skylark.Exception;
using SEPT = Skylark.Enum.PortType;
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
        /// <exception cref="SE"></exception>
        public static string Info(int Port = SSMPPM.Port)
        {
            try
            {
                Port = SHL.Clamp(Port, SSMPPM.MinPort, SSMPPM.MaxPort);

                SSMPPM.List.TryGetValue(Port, out string Result);

                if (string.IsNullOrEmpty(Result))
                {
                    Result = SSMPPM.Unknown;
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
        public static async Task<string> InfoAsync(int Port = SSMPPM.Port)
        {
            return await Task.Run(() => Info(Port));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Ports"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static Dictionary<int, string> Info(int[] Ports = null)
        {
            try
            {
                Ports ??= SSMPPM.Ports;

                if (Ports.Length > SSMPPM.Count)
                {
                    throw new SE(SSMPPM.Error);
                }

                Dictionary<int, string> Result = new();

                foreach (int Port in Ports)
                {
                    int Socket = SHL.Clamp(Port, SSMPPM.MinPort, SSMPPM.MaxPort);

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
        public static SEPT Scan(string Address = SSMPPM.Address, int Port = SSMPPM.Port, int Timeout = SSMPPM.Timeout)
        {
            try
            {
                Address = SHL.Parameter(Address, SSMPPM.Address);
                Port = SHL.Clamp(Port, SSMPPM.MinPort, SSMPPM.MaxPort);
                Timeout = SHL.Clamp(Timeout, SSMPPM.MinTimeout, SSMPPM.MaxTimeout);

                using TcpClient Client = new();

                IAsyncResult Result = Client.BeginConnect(Address, Port, null, null);

                using (Result.AsyncWaitHandle)
                {
                    if (Result.AsyncWaitHandle.WaitOne(SSMPPM.Timeout, false))
                    {
                        Client.EndConnect(Result);
                        return SEPT.Open;
                    }
                    else
                    {
                        return SEPT.Close;
                    }
                }
            }
            catch
            {
                return SEPT.Close;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Port"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public static async Task<SEPT> ScanAsync(string Address = SSMPPM.Address, int Port = SSMPPM.Port, int Timeout = SSMPPM.Timeout)
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
        /// <exception cref="SE"></exception>
        public static Dictionary<int, SEPT> ScanMultiple(string Address = SSMPPM.Address, int[] Ports = null, int Timeout = SSMPPM.Timeout)
        {
            try
            {
                Ports ??= SSMPPM.Ports;

                if (Ports.Length > SSMPPM.Count)
                {
                    throw new SE(SSMPPM.Error);
                }

                Dictionary<int, SEPT> Result = new();

                foreach (int Port in Ports)
                {
                    int Socket = SHL.Clamp(Port, SSMPPM.MinPort, SSMPPM.MaxPort);

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
        public static async Task<Dictionary<int, SEPT>> ScanMultipleAsync(string Address = SSMPPM.Address, int[] Ports = null, int Timeout = SSMPPM.Timeout)
        {
            return await Task.Run(() => ScanMultiple(Address, Ports, Timeout));
        }
    }
}