using DnsClient;
using System.Net;

namespace Skylark.DNS.Manage
{
    /// <summary>
    /// 
    /// </summary>
    public static class External
    {
        /// <summary>
        /// 
        /// </summary>
        public static int Port = 53;

        /// <summary>
        /// 
        /// </summary>
        public static string Server = "8.8.8.8";

        /// <summary>
        /// 
        /// </summary>
        public static LookupClient Client = new(Endpoint);

        /// <summary>
        /// 
        /// </summary>
        public static IPEndPoint Endpoint = new(IPAddress.Parse(Server), Port);
    }
}