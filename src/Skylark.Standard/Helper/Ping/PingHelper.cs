using System.Diagnostics;
using System.Net.Sockets;

namespace Skylark.Standard.Helper.Ping
{
    /// <summary>
    /// 
    /// </summary>
    internal static class PingHelper
    {
        /// <summary>
        /// Removes the "http://" or "https://" prefix from the specified address, if present.
        /// </summary>
        /// <param name="Address">The URL or address string to process. Cannot be null.</param>
        /// <returns>The address string without the "http://" or "https://" prefix. If the prefix is not present, the original
        /// address is returned unchanged.</returns>
        public static string GetAddress(string Address)
        {
            if (Address.Contains("https://"))
            {
                Address = Address.Replace("https://", "");
            }

            if (Address.Contains("http://"))
            {
                Address = Address.Replace("http://", "");
            }

            return Address;
        }

        /// <summary>
        /// Attempts to establish a TCP connection to the specified address and port within the given timeout period.
        /// </summary>
        /// <remarks>This method uses a non-blocking approach to attempt the connection and returns
        /// immediately after the timeout period if the connection is not established.</remarks>
        /// <param name="Address">The hostname or IP address of the target server.</param>
        /// <param name="Port">The port number on the target server to connect to.</param>
        /// <param name="Timeout">The maximum time, in milliseconds, to wait for the connection attempt to complete.</param>
        /// <returns>A tuple containing two values: <list type="bullet"> <item> <description><see langword="true"/> if the
        /// connection was successfully established within the timeout period; otherwise, <see
        /// langword="false"/>.</description> </item> <item> <description>The elapsed time, in milliseconds, taken to
        /// establish the connection, or the timeout value if the connection attempt failed.</description> </item>
        /// </list></returns>
        public static (bool Success, long Elapsed) TcpPing(string Address, int Port, int Timeout)
        {
            try
            {
                Stopwatch Stopwatch = Stopwatch.StartNew();

                using TcpClient Client = new();

                Task Task = Client.ConnectAsync(Address, Port);

                if (!Task.Wait(Timeout))
                {
                    return (false, Timeout);
                }

                Stopwatch.Stop();

                return (true, Stopwatch.ElapsedMilliseconds);
            }
            catch
            {
                return (false, Timeout);
            }
        }
    }
}